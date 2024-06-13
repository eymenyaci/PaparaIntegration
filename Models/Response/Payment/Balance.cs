namespace PaparaIntegration.Models.Response.Payment
{
    public class Balance
    {
        public int currency { get; set; }
        public double totalBalance { get; set; }
        public double lockedBalance { get; set; }
        public double availableBalance { get; set; }
        public string iban { get; set; }
        public CurrencyInfo currencyInfo { get; set; }
    }
}