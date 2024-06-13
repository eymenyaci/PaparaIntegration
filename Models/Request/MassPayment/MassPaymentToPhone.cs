using System.ComponentModel.DataAnnotations;

namespace PaparaIntegration.Models.Request
{
    public class MassPaymentToPhone : MassPayment
    {
        [Required(ErrorMessage = "Account Number is required")]
        public string PhoneNumber { get; set; }

        public bool SendInvitation { get; set; }
    }
}