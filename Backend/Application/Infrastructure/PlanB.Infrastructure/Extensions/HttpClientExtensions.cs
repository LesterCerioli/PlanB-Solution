using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlanB.Infrastructure.Extensions
{
    public static class HttpClientExtensions
    {
        private static readonly JsonSerializer _jsonSerializer = new JsonSerializer();

        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent httpContent){
            using (var stream = await httpContent.ReadAsStreamAsync()){
                var jsonReader = new JsonTextReader(new StreamReader(stream));
                return _jsonSerializer.Deserialize<T>(jsonReader);
            }
        }

        public static Task<HttpResponseMessage> PostJsonAsync<T>(this HttpClient client, string url, T value){
            return SendJsonAsync<T>(client, HttpMethod.Post, url, value);
        }

        public static Task<HttpResponseMessage> PutJsonAsunc<T>(this HttpClient client, string url, T value){
            return SendJsonAsync<T>(client, HttpMethod.Put, url, value);
        }

        public static Task<HttpResponseMessage> SendJsonAsync<T>(this HttpClient client, HttpMethod method, string url, T value){
            var stream = new MemoryStream();
            var jsonWrite = new JsonTextWriter(new StreamWriter(stream));
            _jsonSerializer.Serialize(jsonWrite, value);
            jsonWrite.Flush();
            stream.Position = 0;
            var request = new HttpRequestMessage(method, url){
                Content = new StreamContent(stream)
            };

            request.Content.Headers.TryAddWithoutValidation("Content-Type", "application/json");
            return client.SendAsync(request);
        }
    }
}