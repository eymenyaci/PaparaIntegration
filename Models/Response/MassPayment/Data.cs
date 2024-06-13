namespace PaparaIntegration.Models.Response
{
    public class Data
    {
        public string massPaymentId { get; set; } = "";
        public int massPaymentType { get; set; }
        public int invitationId { get; set; }
        public int id { get; set; }
        public DateTime createdAt { get; set; }
        public decimal amount { get; set; }
        public int currency { get; set; }
        public decimal fee { get; set; }
        public decimal resultingBalance { get; set; }
        public string description { get; set; } = "";
        public int status { get; set; }
    }
}