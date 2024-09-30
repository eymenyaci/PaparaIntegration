using PaparaIntegration.Models.Request.Account;
using PaparaIntegration.Models.Response.Account;
using PaparaIntegration.Models.Response.CorporateCard;

namespace PaparaIntegration.Interfaces
{
    public interface ICorporateCardService
    {
        Task<bool> GetCardDetail();

    }
}