using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace com.alipay.ams.util
{
    public class SignatureUtil
    {

        public static string sign(string requestURI, string clientId, string requestTime,
                              string privateKey, string requestBody)
        {
            string content = string.Format("POST {0}\n{1}.{2}.{3}", requestURI, clientId, requestTime,
                requestBody);

            var keyParam = ImportPrivateKey(privateKey);

            var rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyParam);

            using (var csp = new RSACryptoServiceProvider())
            {
                csp.ImportParameters(rsaParams);
                byte[] vs = csp.SignData(Encoding.UTF8.GetBytes(content), "SHA256");
                return HttpUtility.UrlEncode(Convert.ToBase64String(vs), Encoding.UTF8);
            }
        }

        public static bool verify(string requestURI, string clientId, string responseTime,
                              string alipayPublicKey, string responseBody, string signatureToBeVerified)
        {
            string content = string.Format("POST {0}\n{1}.{2}.{3}", requestURI, clientId, responseTime,
                responseBody);

            var keyParam = ImportPublicKey(alipayPublicKey);

            var rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)keyParam);

            using (var csp = new RSACryptoServiceProvider())
            {
                csp.ImportParameters(rsaParams);
                return csp.VerifyData(Encoding.UTF8.GetBytes(content), "SHA256",
                    Convert.FromBase64String(HttpUtility.UrlDecode(signatureToBeVerified)));
            }
        }

        private static AsymmetricKeyParameter ImportPrivateKey(string base64Key)
        {
            // Try raw DER (PKCS#8) format first
            try
            {
                byte[] keyBytes = Convert.FromBase64String(base64Key);
                return PrivateKeyFactory.CreateKey(keyBytes);
            }
            catch
            {
                // Try PEM format
                string pem = "-----BEGIN RSA PRIVATE KEY-----\n" +
                             FormatPemBase64(base64Key) +
                             "\n-----END RSA PRIVATE KEY-----";
                using (var reader = new StringReader(pem))
                {
                    var obj = new PemReader(reader).ReadObject();
                    if (obj is AsymmetricCipherKeyPair pemPair)
                        return pemPair.Private;
                    return (AsymmetricKeyParameter)obj;
                }
            }
        }

        private static AsymmetricKeyParameter ImportPublicKey(string base64Key)
        {
            // Try raw DER (SubjectPublicKeyInfo) format first
            try
            {
                byte[] keyBytes = Convert.FromBase64String(base64Key);
                return PublicKeyFactory.CreateKey(keyBytes);
            }
            catch
            {
                // Try PEM format
                string pem = "-----BEGIN PUBLIC KEY-----\n" +
                             FormatPemBase64(base64Key) +
                             "\n-----END PUBLIC KEY-----";
                using (var reader = new StringReader(pem))
                {
                    var obj = new PemReader(reader).ReadObject();
                    if (obj is AsymmetricCipherKeyPair pemPair)
                        return pemPair.Public;
                    return (AsymmetricKeyParameter)obj;
                }
            }
        }

        private static string FormatPemBase64(string base64)
        {
            // Insert line breaks every 64 characters for PEM format
            var sb = new StringBuilder();
            for (int i = 0; i < base64.Length; i += 64)
            {
                int len = Math.Min(64, base64.Length - i);
                sb.AppendLine(base64.Substring(i, len));
            }
            // Remove trailing newline
            if (sb.Length > 0 && sb[sb.Length - 1] == '\n')
                sb.Length--;
            return sb.ToString();
        }
    }
}
