using System.ComponentModel.DataAnnotations;

namespace PaparaIntegration.Models.Request
{
    public class MassPaymentToEmail : MassPayment
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}