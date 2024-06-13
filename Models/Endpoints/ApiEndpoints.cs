namespace PaparaIntegration.Models.Endpoints
{
    public static class ApiEndpoints
    {
        public const string BaseUrl = "https://merchant-api.test.papara.com/";

        public class MassPayment
        {
            #region Send MassPayment

            public const string AccountNumber = BaseUrl + "masspayment";

            public const string Phone = BaseUrl + "masspayment/phone";

            public const string Email = BaseUrl + "masspayment/email";

            public const string Tckn = BaseUrl + "masspayment/tckn";

            public const string Iban = BaseUrl + "masspayment/iban";

            #endregion

            #region Inquiry MassPayment
            public const string InquiryWithId = BaseUrl + "masspayment?id=";

            public const string InquiryWithMassPaymentId = BaseUrl + "masspayment/byreference?reference=";

            #endregion

            #region Validate MassPayment

            public const string ValidateWallet = BaseUrl + "masspayment/validation/accountnumber";

            public const string ValidateEmail = BaseUrl + "masspayment/validation/email";

            public const string ValidatePhone = BaseUrl + "masspayment/validation/phone";

            public const string ValidateTckn = BaseUrl + "masspayment/validation/tckn";

            #endregion

        }

        public class Account
        {
            public const string Ledger = BaseUrl + "account/ledgers";
        }

        public class Payment
        {
            public const string CreatePayment = BaseUrl + "payments";

            public const string GetPayment = BaseUrl + "payments?id=";

            public const string CancelPayment = BaseUrl + "payments?=";

            public const string RefundPayment = BaseUrl + "payments/refund";
        }
    }
}