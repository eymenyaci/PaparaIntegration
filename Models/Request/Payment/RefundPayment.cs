namespace PaparaIntegration.Models.Request.Payment
{
    public class RefundPayment
    {
        public string PaymentId { get; set; }

        public decimal RefundAmount { get; set; }
    }
}