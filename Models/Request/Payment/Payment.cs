using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PaparaIntegration.Models.Request.Payment
{
    public class Payment
    {
        public decimal Amount { get; set; }

        public string ReferenceId { get; set; }

        public string OrderDescription { get; set; }

        public string NotificationUrl { get; set; }

        public string FailNotifactionUrl { get; set; }

        public string RedirectUrl { get; set; }

        
        // public int? TurkishNationalId { get; set; } = null;

        public int Currency { get; set; } = 0;
    }
}