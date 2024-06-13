using PaparaIntegration.Models.Response;

namespace PaparaIntegration.Interfaces
{
    public interface IHttpRequestService
    {
        Task<HttpRequestMessage> CreatePostRequestAsnyc(string uri, string jsonPayload);

        Task<T> SendPostRequestAsync<T>(string uri, string jsonPayload);

        Task<HttpRequestMessage> CreateGetRequestAsync(string uri);

        Task<T> SendGetRequestAsync<T>(string uri);

        Task<HttpRequestMessage> CreatePutRequestAsnyc(string uri, string jsonPayload);

        Task<T> SendPutRequestAsync<T>(string uri, string jsonPayload);


    }
}