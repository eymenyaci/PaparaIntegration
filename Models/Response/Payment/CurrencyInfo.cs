namespace PaparaIntegration.Models.Response.Payment
{
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
}