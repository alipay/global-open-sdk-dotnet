using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace com.alipay.ams.util
{
    public class SignatureUtil
    {

        public static string sign(string requestURI, string clientId, string requestTime,
                              string privateKey, string requestBody)
        {

            string content = string.Format("POST {0}\n{1}.{2}.{3}", requestURI, clientId, requestTime,
            requestBody);

            RSA rsa = RSA.Create();
            rsa.ImportPkcs8PrivateKey(Convert.FromBase64String(privateKey), out _);

            byte[] vs = rsa.SignData(Encoding.UTF8.GetBytes(content), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            return HttpUtility.UrlEncode(Convert.ToBase64String(vs), Encoding.UTF8);
        }

        public static bool verify(string requestURI, string clientId, string responseTime,
                              string alipayPublicKey, string responseBody,string signatureToBeVerified)
        {

            string content = string.Format("POST {0}\n{1}.{2}.{3}", requestURI, clientId, responseTime,
            responseBody);

            RSA rsa = RSA.Create();
            rsa.ImportSubjectPublicKeyInfo(Convert.FromBase64String(alipayPublicKey), out _);


            return rsa.VerifyData(Encoding.UTF8.GetBytes(content), Convert.FromBase64String(HttpUtility.UrlDecode(signatureToBeVerified)), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

        }
    }
}
