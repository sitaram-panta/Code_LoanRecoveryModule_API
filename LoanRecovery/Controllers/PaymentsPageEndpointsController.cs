using LoanRecovery.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsPageEndpointsController : ControllerBase
    {
        private readonly PaymentPageServiceRepo repo;
        public PaymentsPageEndpointsController(PaymentPageServiceRepo _repo)
        {
            repo = _repo;

        }

        [HttpGet("displayPaymentsList")]
        public async Task<IActionResult> PaymentsList()
        {
            try
            {
                var details = await repo.DisplayPayments();
                return Ok(details);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }

        }


        [HttpGet("filterPaymentList")]
        public async Task<IActionResult> FilterPaymentList(
          [FromQuery] DateTime? fromDate,
         [FromQuery] DateTime? toDate)
        {
            try
            {
                var details = await repo.FilterPaymentdetails(fromDate, toDate);
                return Ok(details);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }

        }
    }
}
