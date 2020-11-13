﻿using ams_dotnet.example.tests;
using com.alipay.ams.api;

namespace ams_dotnet
{
    class Program
    {
        private const string GatewayUrl = "https://open-sea.alipay.com";
        private const string ClientId = "your_client_id_here";

        // Below are fake keys that are for demo purpose. Replace them with your own ones.
        private const string MerchantPrivateKey = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCKw/v9T90FXjfIrfyVPMflMfmuVdAZxjV8TKlhIy9ONmw5lOIfl4C8qIZ8AnjIzDOaWcNo5mlsUyHvAKZ81tozMPIWqFwJvK3NVm70dp9vfrgkOgdUm5zSNnrq1M3KItkZ41Yip0STtSPfeT/4WR38xUINKDH/nDwGF14Y7tRMbYU6G9q8X0NRQsa3M16QoSNm6YDQDzcW+nSETb+pks0D5yWOjXrZ39RHp1z38yT+IA/orYZdDsO2D9RKUs6DayWliYledChtndLntMR5ktQY4sw13cyrqinlkn/3lUGLvOXIfoVFOeYJNYWCyIzBpdsKPt0nLGBTQIvY13KUpI85AgMBAAECggEAd+meQysVasMdX4yCPZB1iOijw3QiTXOL2qsAn5FhGqxK34N52CT6uYzEEjuslpBnc1VoWKjrpxE7vKYKOM0NZ7k/Kjc4ua1TX6L2ZMhxRE7z31JJ7WI/pSQxGeblImz0wLtEPtPenemlY0MK9ZhFIp5vUqFOe31OHVFqHg+cY6HhuOkIWTOXW3gCxLuPET+ekEKbsx8bGZiAc9Qh/GJzPWlaVggXMPx3KBt1Nmjd1faymjELWxuJk4NB4XM4fwYMopEbTFOc0e+SeAtOs/VpYZ47hPLj9fXqM/JmPdRbbvQYg6vpvgEy4aRswRX2SUjLJ/g2BmS40PkpQyR1cQLgxQKBgQDhqtErYlf+fDzVS3lcj0qeL52BgamA16oKTXSGnMc9pYNzh4kZgMeE4g2iEfNzPcCL0mfB6L+B9XV2XVNC53rnHxoX/11CG58cM7AI6ks4yl8rJngPl9HCt/wq5yNEhSfCoU2RN8N1la66koHWVJeXTerQUmyI9fKzIVGjpFslSwKBgQCdauP+0pTX2eT79qA6shIiE5zSLlS5Nsk6x+mS4C1wxEVBsy5cDes6bKm7CN5IkGfLbpHdXqYNnVczt1rf2CyHaH+Sb4s600+VytoI5HAP5kXEjGfF7KsMv9ujHaRVrCxr9D/p7ELV7c8nBRyZeN8bQvzEXOTW2JQDvXM6JlW/CwKBgBA33IyHptdNSnnx0KkMS0qPFXzHOs1dsoTHCEbcYZ1Wldnptbq1fKFaNayeKabwmzPxTS+scIcAgw6cqm02gai2nYN4ANXNcmPuewpI/Fr6gFhzjVFhkduyqVbUAb7c6vyb5x02qr96oHIcMWSb88EWAngyVEaLloO1M07Vcw99AoGAUNGjMp4M2vE8tfu98cSguKwXFHXC+8Bb+fjPO6Aq1D2ATSXgRFTFEx7c2XDJJro0/+XJr7y7RjwknCGj307ONcr5zEXGVrJMptwZqv0VZ6RS54EqehxzCT2rVwiN6YpW2CnzcnbhLZJFi4P9VfIPoaB3w5zpxEA3ZeArO4yY81cCgYEAuiHiqj5zp6oC8rOXxYSHZ+F3BGw3KCQRU8bOxtW1SZNJSgx65LGro7qpL2KPsvvIpr9xeE25mqMut9PeLgJHSAiK40lWnCpXMeD088PBkbKVaa6ub2vj74hxJHmexqvTJRWeIuWFrhAUGxbzHeVShxwhSiurSzLsLZtG+BEJa2w=";
        private const string AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAhJ5vPPThv5qFZ/3/nOcjJifbq9da9Yu1Xp3wSfJq2vFo0STtws6WGg1t34709Tcg7k4H4rgUnpvBX6h6gjGrFpZLt/uu7Q+cxnWjduvjXy4kanYp5pfSuZvblGR+LPB/yVQo0dh1iDAHk17GT1GuJ0MsBVGykU2Ji+PGkAFeYpaLiLl+uBtOEK8XVyxX7DSW8QNgQpaHBHrBBESqScV2O+ZyII6tVBlYBy/1QPkFDlJHSRTCQngak5HF0WSNYrPLFSMIgrmGDBfO2PFjuqStBNjL7+x9mRSzNF+3LY+uP/XemKmSTtRU5bSM99SNCHW5VGQvJuWX9P17686yRKKYOwIDAQAB";

        static void Main(string[] args)
        {

            //InstorePaymentTest.run(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey), "SGD");

            CashierPaymentTest.run(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey), "PHP");

            //AutoDebitTest.run(new DefaultAlipayClient(GatewayUrl, ClientIdAD, MerchantPrivateKey, AlipayPublicKeyAD), "PHP");
            
        }
    }
}
