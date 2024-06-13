using System.ComponentModel.DataAnnotations;

namespace PaparaIntegration.Models.Request
{
    public class MassPayment
    {
        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, 500000.00, ErrorMessage = "Amount must be between 0.01 and 500000.00")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "MassPaymentId is required")]
        public string MassPaymentId { get; set; }

        [MaxLength(150)]
        public string? Description { get; set; }

        public int Currency { get; set; } = 0;
    }
}