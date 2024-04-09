using LoanRecovery.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowUpPageEndpointsController : ControllerBase
    {
        private readonly FollowUpPageServiceRepo repo;
        public FollowUpPageEndpointsController(FollowUpPageServiceRepo _repo)
        {
            repo = _repo;

        }

        [HttpGet("displayFollowUpList")]
        public async Task<IActionResult> FollowUpList()
        {
            try
            {
                var details = await repo.DisplayFollowUps();
                return Ok(details);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }

        }

        [HttpGet("filterFollowUpList")]
        public async Task<IActionResult> FilterFollowUPList(
          DateTime? fromDate,
         DateTime? toDate)
        {
            try
            {
                var details = await repo.FilterFollowUp(fromDate, toDate);
                return Ok(details);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }

        }
    }
}
