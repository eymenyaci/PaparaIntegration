using Microsoft.Extensions.Configuration;
using PaparaIntegration.Services;
using PaparaIntegration.Interfaces;

namespace PaparaIntegration.Models.Endpoints
{
    public class ApiEndpoints
    {
        public static string BaseUrl { get; private set; }

        public static void ConfigureBaseUrl(IRedisService redisService)
        {
            int isLive = redisService.GetValue<int>("IsLive");
            BaseUrl = isLive == 1
                ? "https://merchant-api.papara.com/"
                : "https://merchant-api.test.papara.com/";
        }

        public class MassPayment
        {
            #region Send MassPayment
            public static string AccountNumber => BaseUrl + "masspayment";
            public static string Phone => BaseUrl + "masspayment/phone";
            public static string Email => BaseUrl + "masspayment/email";
            public static string Tckn => BaseUrl + "masspayment/tckn";
            public static string Iban => BaseUrl + "masspayment/iban";
            #endregion

            #region Inquiry MassPayment
            public static string InquiryWithId => BaseUrl + "masspayment?id=";
            public static string InquiryWithMassPaymentId => BaseUrl + "masspayment/byreference?reference=";
            #endregion

            #region Validate MassPayment
            public static string ValidateWallet => BaseUrl + "masspayment/validation/accountnumber";
            public static string ValidateEmail => BaseUrl + "masspayment/validation/email";
            public static string ValidatePhone => BaseUrl + "masspayment/validation/phone";
            public static string ValidateTckn => BaseUrl + "masspayment/validation/tckn";
            #endregion
        }

        public class Account
        {
            public static string Ledger => BaseUrl + "account/ledgers";
        }

        public class Payment
        {
            public static string CreatePayment => BaseUrl + "payments";
            public static string GetPayment => BaseUrl + "payments?id=";
            public static string CancelPayment => BaseUrl + "payments?=";
            public static string RefundPayment => BaseUrl + "payments/refund";
        }
    }
}
