namespace PaparaIntegration.Models.Response.Payment
{
    public class Data
    {
        public Merchant merchant { get; set; }
        public object userName { get; set; }
        public List<object> relatedTransactions { get; set; }
        public double totalRefundedAmount { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
        public string merchantId { get; set; }
        public object userId { get; set; }
        public int paymentMethod { get; set; }
        public object paymentMethodDescription { get; set; }
        public string referenceId { get; set; }
        public string orderDescription { get; set; }
        public int status { get; set; }
        public object statusDescription { get; set; }
        public double amount { get; set; }
        public double fee { get; set; }
        public int currency { get; set; }
        public CurrencyInfo currencyInfo { get; set; }
        public string notificationUrl { get; set; }
        public string failNotificationUrl { get; set; }
        public bool notificationDone { get; set; }
        public string paymentUrl { get; set; }
        public object merchantSecretKey { get; set; }
        public object remainingRefundAmount { get; set; }
        public string returningRedirectUrl { get; set; }
        public object errorCode { get; set; }
        public object errorMessage { get; set; }
        // public int? turkishNationalId { get; set; }
    }
}