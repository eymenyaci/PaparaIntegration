using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Request;
using PaparaIntegration.Models.Response;
using PaparaIntegration.Models.Endpoints;
using System.Text.Json;

namespace PaparaIntegration.Services
{
    public class MassPaymentService : IMassPaymentService
    {
        private readonly IHttpRequestService _requestService;

        public MassPaymentService(IHttpRequestService httpRequestService)
        {
            _requestService = httpRequestService;
        }

        public async Task<MassPaymentBaseResponseModel> SendMassPayment<T>(T massPayment,string uri)
        {
            var jsonPayload = JsonSerializer.Serialize(massPayment);
            var response = await _requestService.SendPostRequestAsync<MassPaymentBaseResponseModel>(uri, jsonPayload);
            return response;
        }

        public async Task<MassPaymentBaseResponseModel> GetMassPayment(string uri)
        {
            return await _requestService.SendGetRequestAsync<MassPaymentBaseResponseModel>(uri);
        }

        public async Task<DefaultResponseModel> ValidationToMassPayment<T>(T massPayment, string uri)
        {
            var jsonPayload = JsonSerializer.Serialize(massPayment);
            var response = await _requestService.SendPostRequestAsync<DefaultResponseModel>(uri, jsonPayload);
            return response;
        }
    }
}