namespace PaparaIntegration.Models.Response.Account
{
    public class Items
    {
        public int id { get; set; }

        public DateTime createdAt { get; set; }

        public int entryType { get; set; }

        public string entryTypeName { get; set; }

        public decimal amount { get; set; }

        public bool isCashout { get; set; }

        public decimal fee { get; set; }

        public int currency { get; set; }

        public CurrencyInfo currencyInfo { get; set; }
        
        public decimal resultingBalance { get; set; }

        public string description { get; set; }

        public string massPaymentId { get; set; }

        public string checkoutPaymentId { get; set; }

        public string checkoutPaymentReferenceId { get; set; }

        public string operatorUserId { get; set; }

        public decimal commissionAmount { get; set; }

        public string userId { get; set; }

        public bool isCancellation { get; set; }

        public string apiKey { get; set; }

        public bool isLinkPayment { get; set; }

        public string productName { get; set; }

        public string entryTypeTitle { get; set; }

        public string descriptionTitle { get; set; }

        public string iconUrl { get; set; }

        public string transactionUniqueId { get; set; }

        public string referenceNumber { get; set; }

        public int? transactionSource { get; set; }

        public int? paparaCardTxType { get; set; }

        public int? paparaCardId { get; set; }

        public decimal netAmount { get; set; }


    }
}