using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Endpoints;
using PaparaIntegration.Models.Request.Payment;
using PaparaIntegration.Models.Response;
using PaparaIntegration.Models.Response.Payment;
using System.Text.Json;

namespace PaparaIntegration.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IHttpRequestService _requestService;

        public PaymentService(IHttpRequestService requestService)
        {
            _requestService = requestService;
        }
        public Task<DefaultResponseModel> CancelPayment(string uri)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentResponseModel> CreatePayment(Payment payment)
        {
            var jsonPayload = JsonSerializer.Serialize(payment);
            var response = await _requestService.SendPostRequestAsync<PaymentResponseModel>(ApiEndpoints.Payment.CreatePayment,jsonPayload);
            return response;
        }

        public async Task<PaymentResponseModel> GetPayment(string uri)
        {
            return await _requestService.SendGetRequestAsync<PaymentResponseModel>(uri);
        }

        public async Task<DefaultResponseModel> RefundPayment(RefundPayment payment)
        {
            var jsonPayload = JsonSerializer.Serialize(payment);
            var response = await _requestService.SendPostRequestAsync<DefaultResponseModel>(ApiEndpoints.Payment.RefundPayment,jsonPayload);
            return response;
        }
    }
}