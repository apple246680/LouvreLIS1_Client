using NUnit.Framework;
using System.Drawing;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Text.Json;
using System.Text;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Threading;

namespace LouvreLIS_UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            Random rd = new Random();
            string jsonData = JsonSerializer.Serialize(new
            {
                StationNumber = rd.Next(1, 20)
            }); ;
            HttpClient http = new HttpClient
            {
                Timeout = TimeSpan.FromMilliseconds(3000)
            };
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = http.PostAsync("http://localhost:500/api/ConnectionMonitor/RetrieveSiteStatus", content).Result;
                if (response.IsSuccessStatusCode)
                    Assert.Pass();
                else
                    Assert.Fail();
            }
            catch (AggregateException ex) when (ex.InnerException is TimeoutException)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void test2()
        {
            int count = 0;
            var HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Response = new HttpResponseMessage();
            for (int i = 32; i <= 512; i++)
            {
                string JsonData = JsonSerializer.Serialize(new
                {
                    Text = "a",
                    SizePixels = i,
                    CorrectionLevel = 0
                });
                HttpContent content = new StringContent(JsonData, Encoding.UTF8, "application/json");
                Response = HttpClient.PostAsync("http://localhost:500/Image/GenerateQRCode", content).Result;
                if (Response.IsSuccessStatusCode)
                    count++;
            }
            if (count < 480) Assert.Fail(); else Assert.Pass();
        }
    }
}