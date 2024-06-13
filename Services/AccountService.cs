using System.Text.Json;
using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Endpoints;
using PaparaIntegration.Models.Request.Account;
using PaparaIntegration.Models.Response.Account;

namespace PaparaIntegration.Services
{
    public class AccountService : IAccountService
    {
        private readonly IHttpRequestService _requestService;

        public AccountService(IHttpRequestService requestService)
        {
            _requestService = requestService;
        }
        public async Task<LedgerResponseModel> GetLedgers(Ledger ledger)
        {
            var jsonPayload = JsonSerializer.Serialize(ledger);
            var response = await _requestService.SendPostRequestAsync<LedgerResponseModel>(ApiEndpoints.Account.Ledger, jsonPayload);
            return response;
        }
    }
}