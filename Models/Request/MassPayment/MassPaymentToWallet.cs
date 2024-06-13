using System.ComponentModel.DataAnnotations;

namespace PaparaIntegration.Models.Request
{
    public class MassPaymentToWallet : MassPayment
    {
        [Required(ErrorMessage = "Account Number is required")]

        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Account Number must be exactly 10 digits")]
        public string AccountNumber { get; set; }
    }
}