using System.Text;
using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Request;
using PaparaIntegration.Models.Response;
using PaparaIntegration.Models.Endpoints;
using System.Text.Json;

namespace PaparaIntegration.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        private const string ApiKey = "sYxI84PYeKPHeXQSE8+c1bmlzgyfaeQ8zErKnSJI1PsxCn9vPUSGmH31wb9N0Wfi502AD0/ie5ksEsam8a9K6g==";
        private readonly HttpClient _httpClient;

        public HttpRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpRequestMessage> CreatePostRequestAsnyc(string uri, string jsonPayload)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Add("ApiKey", ApiKey);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            return request;
        }

        public async Task<T> SendPostRequestAsync<T>(string uri, string jsonPayload)
        {
            var request = await CreatePostRequestAsnyc(uri, jsonPayload);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }

        public async Task<HttpRequestMessage> CreateGetRequestAsync(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.Add("ApiKey", ApiKey);
            return request;
        }

        public async Task<T> SendGetRequestAsync<T>(string uri)
        {
            var request = await CreateGetRequestAsync(uri);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }

        public async Task<HttpRequestMessage> CreatePutRequestAsnyc(string uri, string jsonPayload)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            request.Headers.Add("ApiKey", ApiKey);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            return request;
        }

        public async Task<T> SendPutRequestAsync<T>(string uri, string jsonPayload)
        {
            var request = await CreatePutRequestAsnyc(uri, jsonPayload);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }
    }
}