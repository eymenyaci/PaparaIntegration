using PaparaIntegration.Models.Request.Account;
using PaparaIntegration.Models.Response.Account;

namespace PaparaIntegration.Models
{
    public class LedgerViewModel
    {
        public LedgerResponseModel PayoutLedgers { get; set; }

        public LedgerResponseModel PaymentLedgers { get; set; }

    }
}