using System.ComponentModel.DataAnnotations;

namespace PaparaIntegration.Models.Request
{
    public class MassPaymentToTckn : MassPayment
    {
        [Required(ErrorMessage = "TCKN is required")]
        [Range(10000000000, 99999999999, ErrorMessage = "Turkish National ID must be exactly 11 digits and not start with 0")]
        public ulong TurkishNationalId { get; set; }
    }
}