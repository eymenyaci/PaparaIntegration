namespace PaparaIntegration.Models.Request.Account
{
    public class Ledger
    {
        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int page { get; set; }

        public int pageSize { get; set; }

        public int? entryType { get; set; }

    }
}