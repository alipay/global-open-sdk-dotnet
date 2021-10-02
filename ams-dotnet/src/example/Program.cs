using ams_dotnet.example.tests;
using com.alipay.ams.api;

namespace ams_dotnet
{
    class Program
    {
        private const string GatewayUrl = "https://open-sea.alipay.com";
        private const string ClientId = "SANDBOX_5Y0238SG0YEY07087";

        // Below are fake keys that are for demo purpose. Replace them with your own ones.
        private const string MerchantPrivateKey = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCfF05lbHfjlLFHIcXuSQunNOEnnu40bOp4rEWsl18CY6NvC7StN5eiR9C2SRit//ISKFgDfGLIxhksGNiKpWDUhe0YqGEl3QMZuDfRqBTemNjyFaoZs75Q6/uJUl0aSHtMiISMH2vhnQ8B8XBhWVagLNcx32F5qe63kLtKqq7GaCokRUM2uHUWeyx/dzZigtjG7/Xkcwgp7j8JJybr4ybrXCSG6dvlRxB6RWgj2wyhPJ9J+ddqtpwv/iFnyALevcRx4ij6LC8k1OAULm2yIOa+xSJxw5tWA3ZmRrdHcRgtgiA/BszzjVxsuJljuVgRGgpEI4tbeGq0Va3B6GNgI0JzAgMBAAECggEAAqm4NTholVWi1gb5sjBk0oqvDiO55wS/s/9mNypde8PBM5Wlk5SvpBbBppt4n0j+e1FTj9NgL+4o87UCwudbxJLtUhFXdvPJHoAX5xmCJ+u1DfBQ5Zc9o0sf7b+EMXFvJuvOFC5edutTGfw5nleJfKrje0E693dhuI7io7BRtp5214TEyIfBWNkZ0NRZLoNuJ/oQNzWatyYZrUhY7TSbx2CCq1TEEtzYYFHv1bdPb27xzhtfqm/1Vh1LPzF7K2oUgaaoTgXqiaksnd24RJI0Mam5a+O2P7R9vGJG+MtqZd5GnxBZMw4DlW2gw4huQTeNBih2xig65Sj1Mzjg53E/8QKBgQD4HGsVMYtx+ZKzhcEUlCUzPrUqgVw+IyxEUmiWP5ISj74ZGiUt2uq8T7Z3rBxb2Bi4OXVxo1e120+3rliLesPOMvappdHq0utz3P7EAdVtAjROeywFIT93Qqpf7twxeWHzVATL2snHamlZ7CEz8S93J6I21c330k6PkziL9Z6PWQKBgQCkJkfKTdwQRhvkGwtOpOropVlR+WrRUXok3QKolJ9CkTk4gETveA9/EQxz7rn87A5goo+m7m4fBWyFJceX2jvJ+CwmQlUAgoTHN87JH/dJOl4rGRlN/9pL8eazgger1Gfv7kgvcSi2gpw2j9GZH0L2l5t7lREd2PX/kdkeDOdSqwKBgQC3s/LlQkXJIcyo90O6hOX2R1vEGPu/VjOUcp/Vf0QcUimiVGVqykg7HZowiVKF/j5vSLvYY+SxVax0h7Yvr7oClmFjws7mWzzSELLhVao8iAFKipBRTAi9uLKFTUnjp8gKbg8PEPONnxBZ8Ce1WcKXKtVEXJGgCCr6yzp3BmlcIQKBgBEKFDuw114tGOoV0JeqUOQzfdEflfIChi5bbtI3E00irBDsZ7t/+APVrjg+mLnjex6W4ViPuYio1HoB0PU3ZytxAow6KH60DbpsVZ/VHKNSVsIcid7p5ywpASyzG76/fsaOMpoSIgrIBhU32qcNcrMMS8yJTcyOYALWjfYrmrufAoGAEeYoNCjEiCJPb0WMPUFyIRZdbEf6ayptR5LAHKPr9GOlKFUeFkd3E0z8tuixp3ETmoPVufxhvPh1NXQ3vEb843WsQfQGM9BCOQYPaDYUnhK5m35ARfAKDtG9a63BSJ+9YznonShmcL9zHehuLI871z4/MjFVmiwhMrq+Vj/h/bU=";
        private const string AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAhJ5vPPThv5qFZ/3/nOcjJifbq9da9Yu1Xp3wSfJq2vFo0STtws6WGg1t34709Tcg7k4H4rgUnpvBX6h6gjGrFpZLt/uu7Q+cxnWjduvjXy4kanYp5pfSuZvblGR+LPB/yVQo0dh1iDAHk17GT1GuJ0MsBVGykU2Ji+PGkAFeYpaLiLl+uBtOEK8XVyxX7DSW8QNgQpaHBHrBBESqScV2O+ZyII6tVBlYBy/1QPkFDlJHSRTCQngak5HF0WSNYrPLFSMIgrmGDBfO2PFjuqStBNjL7+x9mRSzNF+3LY+uP/XemKmSTtRU5bSM99SNCHW5VGQvJuWX9P17686yRKKYOwIDAQAB";

        static void Main(string[] args)
        {

            //InstorePaymentTest.run(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey), "SGD");

            OrderCodeTest.run(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey), "MOP");

            //AutoDebitTest.run(new DefaultAlipayClient(GatewayUrl, ClientIdAD, MerchantPrivateKey, AlipayPublicKeyAD), "PHP");


            //RegistrationTest.run(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));

        }
    }
}
