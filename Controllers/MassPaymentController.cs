using Microsoft.AspNetCore.Mvc;
using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Request;
using PaparaIntegration.Models.Response;
using PaparaIntegration.Models.Endpoints;

namespace PaparaIntegration.Controllers
{
    [Route("[controller]")]
    public class MassPaymentController : Controller
    {
        private readonly IMassPaymentService _massPaymentService;
        public MassPaymentController(IMassPaymentService massPaymentService)
        {
            _massPaymentService = massPaymentService;
        }

        [HttpPost("AccountNumber")]
        public async Task<IActionResult> AccountNumber([FromBody] MassPaymentToWallet massPayment)
        {
            string uri = ApiEndpoints.MassPayment.AccountNumber;
            var response = await _massPaymentService.SendMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Tckn")]
        public async Task<IActionResult> Tckn([FromBody] MassPaymentToTckn massPayment)
        {
            string uri = ApiEndpoints.MassPayment.Tckn;
            var response = await _massPaymentService.SendMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Email")]
        public async Task<IActionResult> Email([FromBody] MassPaymentToEmail massPayment)
        {
            string uri = ApiEndpoints.MassPayment.Email;
            var response = await _massPaymentService.SendMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Phone")]
        public async Task<IActionResult> Phone([FromBody] MassPaymentToPhone massPayment)
        {
            string uri = ApiEndpoints.MassPayment.Phone;
            var response = await _massPaymentService.SendMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Validate/AccountNumber")]
        public async Task<IActionResult> ValidateAccountNumber([FromBody] MassPaymentToWallet massPayment)
        {
            string uri = ApiEndpoints.MassPayment.ValidateWallet;
            var response = await _massPaymentService.ValidationToMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Validate/Tckn")]
        public async Task<IActionResult> ValidateTckn([FromBody] MassPaymentToTckn massPayment)
        {
            string uri = ApiEndpoints.MassPayment.ValidateTckn;
            var response = await _massPaymentService.ValidationToMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Validate/Phone")]
        public async Task<IActionResult> ValidatePhone([FromBody] MassPaymentToPhone massPayment)
        {
            string uri = ApiEndpoints.MassPayment.ValidatePhone;
            var response = await _massPaymentService.ValidationToMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpPost("Validate/Email")]
        public async Task<IActionResult> ValidateEmail([FromBody] MassPaymentToEmail massPayment)
        {
            string uri = ApiEndpoints.MassPayment.ValidateEmail;
            var response = await _massPaymentService.ValidationToMassPayment(massPayment, uri);
            return Ok(response);
        }

        [HttpGet("Detail")]
        public async Task<IActionResult> GetMassPayment(string referenceId)
        {
            string uri = ApiEndpoints.MassPayment.InquiryWithMassPaymentId + referenceId;
            var response = await _massPaymentService.GetMassPayment(uri);
            return Ok(response);
        }
    }
}