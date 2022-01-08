using AuphonicApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AuphonicApi
{
    public class Api : IApi
    {
        private const string _baseUrl = "https://auphonic.com/api/";

        public async Task<Response<T>> GetRequest<T>(string path)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, _baseUrl + path);
            request.AddBasicAuth();
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<T>>(responseContent);
        }

        public async Task<Response<T>> PostRequest<T>(string path, Dictionary<string, object> parameters)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Post, _baseUrl + path);
            request.AddBasicAuth();
            string parameterString=string.Empty;
            if (parameters!=null)
            {
                parameterString = JsonConvert.SerializeObject(parameters);
                
            }
            request.Content = new StringContent(parameterString);
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<T>>(responseContent);
        }

        public async Task UploadMultipartFile(string path, string fileName, byte[] data)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Post, _baseUrl + path);
            request.AddBasicAuth();
            request.Content = new MultipartFormDataContent
            {
                { new ByteArrayContent(data),  "input_file", fileName }
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }
    }
}