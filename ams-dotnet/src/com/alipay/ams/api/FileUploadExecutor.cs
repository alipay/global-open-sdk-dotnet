using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;
using com.alipay.ams.api.request.billing;
using com.alipay.ams.api.response;
using com.alipay.ams.api.response.billing;
using com.alipay.ams.util;

namespace com.alipay.ams.api
{
    internal static class FileUploadExecutor
    {
        private static readonly IReadOnlyDictionary<Type, FileUploadOperation> Operations =
            new Dictionary<Type, FileUploadOperation>
            {
                {
                    typeof(AlipayProductUploadImageRequest),
                    new FileUploadOperation(
                        "/ams/api/v1/billing/product/uploadImage",
                        2 * 1024 * 1024,
                        new[] { "file", "imageFile" },
                        typeof(AlipayProductUploadImageResponse),
                        BuildProductImageBody)
                }
            };

        internal static TAMSResponse Execute<TAMSResponse>(
            DefaultAlipayClient client,
            string explicitUploadGatewayUrl,
            AMSFileRequest<TAMSResponse> request)
            where TAMSResponse : AMSResponse
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (!Operations.TryGetValue(request.GetType(), out var operation)
                || operation.ResponseType != typeof(TAMSResponse))
            {
                throw new ArgumentException(
                    "Only SDK-provided file upload requests are supported", nameof(request));
            }
            var preparedFile = ReadFile(request.File, operation.MaxFileSize);
            var body = operation.BuildBody(request);
            using (var sha256 = SHA256.Create())
            {
                body["fileSha256"] = ToLowerHex(sha256.ComputeHash(preparedFile.Content));
            }
            var requestBody = JsonSerializer.Serialize(
                body,
                JsonSerializerOptionsFactory.WriteNotIndented);
            var path = client.BuildRequestUri(operation.Path);
            var gateway = UploadGatewayResolver.Resolve(client.GatewayUrl, explicitUploadGatewayUrl);
            var requestTime = DateTime.UtcNow.ToString("o");
            var signature = SignatureUtil.sign(
                path,
                client.ClientId,
                requestTime,
                client.MerchantPrivateKey,
                requestBody);
            var keyVersion = string.IsNullOrWhiteSpace(request.KeyVersion) ? "1" : request.KeyVersion;
            var headers = new Dictionary<string, string>
            {
                { "client-id", client.ClientId },
                { "signature", "algorithm=RSA256,keyVersion=" + keyVersion + ",signature=" + signature },
                { "request-time", requestTime },
                { "User-Agent", SdkVersion.UserAgent },
                { "X-sdkVersion", "ams-dotnet.20201113" }
            };
            if (!string.IsNullOrEmpty(client.AgentToken))
            {
                headers.Add("Agent-Token", client.AgentToken);
            }

            var requestUrl = gateway + path;
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl))
            using (var multipart = MultipartHttpRPC.CreateContent(
                requestBody,
                operation.FilePartNames,
                preparedFile.Name,
                preparedFile.Type,
                preparedFile.Content))
            {
                foreach (var header in headers)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }
                requestMessage.Content = multipart;
                using (var responseMessage = MultipartHttpRPC.Send(requestMessage))
                {
                    var responseBody = responseMessage.Content.ReadAsStringAsync()
                        .ConfigureAwait(false).GetAwaiter().GetResult();
                    if (responseMessage.StatusCode != HttpStatusCode.OK)
                    {
                        throw new HttpRequestException(
                            "File upload response HTTP status was " + responseMessage.StatusCode
                            + ", response body: " + responseBody);
                    }
                    var response = JsonSerializer.Deserialize<TAMSResponse>(
                        responseBody,
                        JsonSerializerOptionsFactory.WriteNotIndented);
                    if (response == null || response.Result == null)
                    {
                        throw new InvalidOperationException("File response result field is missing");
                    }
                    VerifyResponse(
                        responseMessage,
                        path,
                        client.ClientId,
                        client.AlipayPublicKey,
                        responseBody,
                        response.Result);
                    return response;
                }
            }
        }

        private static Dictionary<string, string> BuildProductImageBody(object request)
        {
            var productRequest = (AlipayProductUploadImageRequest)request;
            if (string.IsNullOrWhiteSpace(productRequest.ProductId))
            {
                throw new ArgumentException("ProductId cannot be empty", nameof(request));
            }
            if (productRequest.ProductId.Length > 64)
            {
                throw new ArgumentException(
                    "ProductId length cannot exceed 64 characters", nameof(request));
            }
            return new Dictionary<string, string>
            {
                { "productId", productRequest.ProductId }
            };
        }

        private static PreparedFile ReadFile(AlipayFileContent file, int maxFileSize)
        {
            if (file == null || file.Stream == null || !file.Stream.CanRead)
            {
                throw new ArgumentException("File must contain a readable stream", nameof(file));
            }
            var stream = file.Stream;
            var originalPosition = stream.CanSeek ? stream.Position : -1;
            byte[] content;
            try
            {
                using (var buffer = new MemoryStream())
                {
                    var chunk = new byte[81920];
                    while (buffer.Length <= maxFileSize)
                    {
                        var remaining = maxFileSize + 1 - (int)buffer.Length;
                        var read = stream.Read(chunk, 0, Math.Min(chunk.Length, remaining));
                        if (read == 0)
                        {
                            break;
                        }
                        buffer.Write(chunk, 0, read);
                    }
                    content = buffer.ToArray();
                }
            }
            finally
            {
                if (originalPosition >= 0)
                {
                    stream.Position = originalPosition;
                }
            }
            if (content.Length == 0)
            {
                throw new ArgumentException("File cannot be empty", nameof(file));
            }
            if (content.Length > maxFileSize)
            {
                throw new ArgumentException(
                    "File size cannot exceed " + maxFileSize + " bytes", nameof(file));
            }

            var name = file.FileName;
            if (string.IsNullOrWhiteSpace(name) && stream is FileStream fileStream)
            {
                name = fileStream.Name;
            }
            name = string.IsNullOrWhiteSpace(name)
                ? null
                : MultipartHttpRPC.SanitizeFileName(name);
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "File Name is required for streams other than FileStream", nameof(file));
            }
            var contentType = string.IsNullOrWhiteSpace(file.ContentType)
                ? GetContentType(name)
                : file.ContentType;
            return new PreparedFile(content, name, contentType);
        }

        private static void VerifyResponse(
            HttpResponseMessage response,
            string path,
            string clientId,
            string publicKey,
            string responseBody,
            Result result)
        {
            var signature = GetHeader(response, "signature");
            var responseTime = GetHeader(response, "response-time");
            if (string.IsNullOrWhiteSpace(signature) && string.IsNullOrWhiteSpace(responseTime))
            {
                if (result.ResultStatus == ResultStatusType.F)
                {
                    return;
                }
                throw new InvalidOperationException("Unsigned file response is not a failure response");
            }
            if (string.IsNullOrWhiteSpace(signature) || string.IsNullOrWhiteSpace(responseTime))
            {
                throw new InvalidOperationException(
                    "File response must contain both Signature and Response-Time");
            }
            var marker = "signature=";
            var markerIndex = signature.LastIndexOf(marker, StringComparison.OrdinalIgnoreCase);
            var rawSignature = markerIndex < 0
                ? signature
                : signature.Substring(markerIndex + marker.Length);
            if (!SignatureUtil.verify(path, clientId, responseTime, publicKey, responseBody, rawSignature))
            {
                throw new InvalidOperationException("File response signature verification failed");
            }
        }

        private static string GetHeader(HttpResponseMessage response, string name)
        {
            return response.Headers.TryGetValues(name, out var values)
                ? values.FirstOrDefault()
                : null;
        }

        private static string ToLowerHex(byte[] value)
        {
            return BitConverter.ToString(value).Replace("-", string.Empty).ToLowerInvariant();
        }

        private static string GetContentType(string name)
        {
            switch (Path.GetExtension(name).ToLowerInvariant())
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                default:
                    return "application/octet-stream";
            }
        }

        private sealed class FileUploadOperation
        {
            internal FileUploadOperation(
                string path,
                int maxFileSize,
                IReadOnlyList<string> filePartNames,
                Type responseType,
                Func<object, Dictionary<string, string>> buildBody)
            {
                Path = path;
                MaxFileSize = maxFileSize;
                FilePartNames = filePartNames;
                ResponseType = responseType;
                BuildBody = buildBody;
            }

            internal string Path { get; }
            internal int MaxFileSize { get; }
            internal IReadOnlyList<string> FilePartNames { get; }
            internal Type ResponseType { get; }
            internal Func<object, Dictionary<string, string>> BuildBody { get; }
        }

        private sealed class PreparedFile
        {
            internal PreparedFile(byte[] content, string name, string type)
            {
                Content = content;
                Name = name;
                Type = type;
            }

            internal byte[] Content { get; }
            internal string Name { get; }
            internal string Type { get; }
        }
    }
}
