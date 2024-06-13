using Microsoft.AspNetCore.Mvc;
using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Request;
using PaparaIntegration.Models.Endpoints;
using PaparaIntegration.Services;
using PaparaIntegration.Models.Request.Payment;

namespace PaparaIntegration.Controllers
{
    [Route("[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] Payment payment)
        {
            var response = await _paymentService.CreatePayment(payment);
            return Ok(response);
        }

        [HttpGet("Inquiry")]
        public async Task<IActionResult> GetPayment(string referenceId)
        {
            string uri = ApiEndpoints.Payment.GetPayment + referenceId;
            var response = await _paymentService.GetPayment(uri);
            return Ok(response);
        }

        [HttpPost("Refund")]
        public async Task<IActionResult> RefundPayment([FromBody] RefundPayment payment)
        {
            var response = await _paymentService.RefundPayment(payment);
            return Ok(response);  
        }






    }
}