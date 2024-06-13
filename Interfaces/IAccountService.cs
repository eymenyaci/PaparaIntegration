using PaparaIntegration.Models.Request.Account;
using PaparaIntegration.Models.Response.Account;

namespace PaparaIntegration.Interfaces
{
    public interface IAccountService
    {
        Task<LedgerResponseModel> GetLedgers(Ledger ledger);
    }
}