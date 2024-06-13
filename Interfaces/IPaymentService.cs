using PaparaIntegration.Models.Response.Payment;
using PaparaIntegration.Models.Request.Payment;
using PaparaIntegration.Models.Response;
namespace PaparaIntegration.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentResponseModel> CreatePayment(Payment payment);

        Task<PaymentResponseModel> GetPayment(string uri);

        Task<DefaultResponseModel> RefundPayment(RefundPayment payment);

        Task<DefaultResponseModel> CancelPayment(string uri);
    }
}