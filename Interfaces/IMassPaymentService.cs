using PaparaIntegration.Models.Request;
using PaparaIntegration.Models.Response;
namespace PaparaIntegration.Interfaces
{
    public interface IMassPaymentService
    {
        Task<MassPaymentBaseResponseModel> SendMassPayment<T>(T massPayment,string uri);

        Task<MassPaymentBaseResponseModel> GetMassPayment(string uri);

        Task<DefaultResponseModel> ValidationToMassPayment<T>(T massPayment,string uri);

    }
}