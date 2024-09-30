namespace PaparaIntegration.Models.Response.CorporateCard
{
    public class ApiResponse
    {
        public Data data { get; set; }
        public bool succeeded { get; set; }
    }

    public class Data
    {
        public long cardId { get; set; }
        public string merchantId { get; set; }
        public VirtualCardInfo virtualCardInfo { get; set; }

        public object merchant { get; set; }
        public string maskedPan { get; set; }
        public string description { get; set; }
        public string phoneNumber { get; set; }
        public int status { get; set; }
        public int type { get; set; }
        public Balance balance { get; set; }
        public List<object> allowedPosCategories { get; set; }
        public List<object> externalCardAcceptorPaparaCards { get; set; }
        public List<object> allowedExternalCardAcceptors { get; set; }
        public bool isVirtual { get; set; }
        public string tokenizedCardNumber { get; set; }
        public string expireDate { get; set; }
        public string iconUrl { get; set; }
        public object bigIconUrl { get; set; }
        public int balanceUsage { get; set; }
        public bool atmWithdrawEnabled { get; set; }
        public bool atmDepositEnabled { get; set; }
        public object activationDate { get; set; }
        public bool isPhoneNumberBlocked { get; set; }
        public object paparaCardStatusDescription { get; set; }
        public string paparaCardTypeDescription { get; set; }
        public string expiryYear { get; set; }
        public string expiryMonth { get; set; }
        public CurrencyInfo currencyInfo { get; set; }
        public int serviceType { get; set; }
        public double merchantAvailableBalance { get; set; }
        public bool isCorporateCardListOnPaparaAppEnabled { get; set; }
        public DateTime createdAt { get; set; }
        public bool isLive { get; set; }
        public string encryptedCardNumber { get; set; }
        public string encryptedEncryptionPassword { get; set; }
        public int network { get; set; }
        public int logoType { get; set; }
        public string cardNumber { get; set; }
        public string cvv { get; set; }
    }

    public class Balance
    {
        public string ownerId { get; set; }
        public long paparaCardId { get; set; }
        public double totalBalance { get; set; }
        public DateTime endOfTheDay { get; set; }
        public double endOfTheDayBalance { get; set; }
        public double intradaySpendingVolume { get; set; }
        public double intradaySpendingOverVolume { get; set; }
        public int tick { get; set; }
        public string rowVersion { get; set; }
        public long id { get; set; }
        public DateTime createdAt { get; set; }
    }

    public class CurrencyInfo
    {
        public int currencyEnum { get; set; }
        public string symbol { get; set; }
        public string code { get; set; }
        public int number { get; set; }
        public string preferredDisplayCode { get; set; }
        public string name { get; set; }
        public bool isCryptocurrency { get; set; }
        public bool isInternationalMoneyTransferCurrency { get; set; }
        public int precision { get; set; }
        public string iconUrl { get; set; }
        public string flagUrl { get; set; }
        public int currencyEnumIso { get; set; }
        public bool isMetalCurrency { get; set; }
    }

    public class VirtualCardInfo
    {
        public string cardNumber { get; set; }
        public string tokenizedCardNumber { get; set; }
        public string expiryMonth { get; set; }
        public string expiryYear { get; set; }
        public string cvv { get; set; }
    }
}