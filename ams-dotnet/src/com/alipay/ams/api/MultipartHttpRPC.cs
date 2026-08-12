using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace com.alipay.ams.api
{
    internal static class MultipartHttpRPC
    {
        private static readonly HttpClient Client = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(30)
        };

        internal static MultipartFormDataContent CreateContent(
            string requestBody,
            IReadOnlyList<string> filePartNames,
            string fileName,
            string contentType,
            byte[] fileContent)
        {
            var boundary = "----AntomBoundary" + Guid.NewGuid().ToString("N");
            var multipart = new MultipartFormDataContent(boundary);

            var bodyContent = new StringContent(requestBody, Encoding.UTF8, "application/json");
            multipart.Add(bodyContent, "body");

            foreach (var filePartName in filePartNames)
            {
                multipart.Add(
                    CreateFileContent(fileContent, contentType),
                    filePartName,
                    SanitizeFileName(fileName));
            }
            return multipart;
        }

        internal static HttpResponseMessage Send(HttpRequestMessage request)
        {
            return Client.SendAsync(request).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private static ByteArrayContent CreateFileContent(byte[] fileContent, string contentType)
        {
            var content = new ByteArrayContent(fileContent);
            content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            content.Headers.Add("Content-Transfer-Encoding", "binary");
            return content;
        }

        internal static string SanitizeFileName(string fileName)
        {
            var separator = fileName.LastIndexOfAny(new[] { '/', '\\' });
            var baseName = separator >= 0 ? fileName.Substring(separator + 1) : fileName;
            var characters = baseName.ToCharArray();
            for (var index = 0; index < characters.Length; index++)
            {
                if (characters[index] == '"' || char.IsControl(characters[index]))
                {
                    characters[index] = '_';
                }
            }
            return new string(characters);
        }
    }
}
