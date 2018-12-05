using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class HttpPostHelper
    {
        public HttpResponseMessage SendPostRequest(object content, string requestUrl)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                var request = new HttpRequestMessage(HttpMethod.Post, requestUrl);

                var json = JsonConvert.SerializeObject(content);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                request.Content = stringContent;
                var response = client.SendAsync(request).Result;

                return response;
            }
        }
    }
}
