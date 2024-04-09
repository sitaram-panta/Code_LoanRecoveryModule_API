using LoanRecovery.Enums;
using LoanRecovery.Services;
using LoanRecovery.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DefaultersRelatedEndpointsController : ControllerBase
    {
        protected readonly DefaulterPageServiceRepo repo;

        public DefaultersRelatedEndpointsController(DefaulterPageServiceRepo _repo)
        {
            repo = _repo;

        }


        [HttpGet("DefaulterListView")]
        public ActionResult<IQueryable<DefaultersViewModel>> DefaultersListView()
        {
            try
            {
                var defaulters = repo.GetDefaulters().AsQueryable();
                return Ok(defaulters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("FilteredDefaulter")]
        public async Task<IActionResult> GetFilteredDefaulters([FromQuery] DateTime? fromDate,
            [FromQuery] DateTime? toDate,
            [FromQuery] RepaymentType? repaymentType,
            [FromQuery] Status? status,
            [FromQuery] int? loanId)
        {
            try
            {
                var filterDefaulters = await repo.FilterDefaulter(fromDate, toDate, repaymentType, status, loanId);
                return Ok(filterDefaulters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("GuarantorInfo/{id}")]
        public async Task<IActionResult> GetGuarantorInfo(int id)
        {
            try
            {
                var guarantorInfo = await repo.GuarantorInfo(id);
                return Ok(guarantorInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("FollowUpInfo/{id}")]
        public async Task<IActionResult> GetFollowUpInfo(int id)
        {
            try
            {
                var followupInfo = await repo.FollowUpInfo(id);
                return Ok(followupInfo);

            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }

        }

        [HttpGet("FilterFollowUP")]
        public async Task<IActionResult> FilterFollowupInfo(
        [FromQuery] DateTime? fromDate,
        [FromQuery] DateTime? toDate)
        {
            try
            {
                var filterdata = await repo.FilterFollowUpdetails(fromDate, toDate);
                return Ok(filterdata);

            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }


        }


        [HttpGet("PaymentInfo/{id}")]
        public async Task<IActionResult> GetPaymentInfo(int id)
        {
            try
            {
                var paymentInfo = await repo.PaymentInfo(id);
                return Ok(paymentInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("FilterPayments")]
        public async Task<IActionResult> FilterPaymentInfo(
         [FromQuery] DateTime? fromDate,
         [FromQuery] DateTime? toDate)
        {
            try
            {
                var filterdata = await repo.FilterPaymentdetails(fromDate, toDate);
                return Ok(filterdata);

            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }


        }

        [HttpGet("SecurityInfo/{id}")]
        public async Task<IActionResult> GetSecurityInfo(int id)
        {
            try
            {
                var securityInfo = await repo.LoanSecurityInfo(id);
                return Ok(securityInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("ReminderInfo/{id}")]
        public async Task<IActionResult> GetReminderInfo(int id)
        {
            try
            {
                var reminderInfo = await repo.ReminderInfo(id);
                return Ok(reminderInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("LegalInfo/{id}")]
        public async Task<IActionResult> GetLegalInfo(int id)
        {
            try
            {
                var legalInfo = await repo.LegalInfo(id);
                return Ok(legalInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("BiddingInfo/{id}")]
        public async Task<IActionResult> GetBiddingInfo(int id)
        {
            try
            {
                var biddingInfo = await repo.BiddingInfo(id);
                return Ok(biddingInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //loanrecovery Missing

        [HttpGet("LoanDetails")]
        public async Task<IActionResult> GetLoanDetails(
        [FromQuery] bool includeDefaultersList,
        [FromQuery] bool includeGuarantorInfo,
        [FromQuery] bool includePaymentInfo,
        [FromQuery] bool includeSecurityInfo,
        [FromQuery] bool includeFollowUpInfo,
        [FromQuery] bool includeBiddingInfo,
        [FromQuery] int? id = null)
        {
            try
            {
                var result = await repo.DetailsByFunctionalities
                    (includeGuarantorInfo,
                    includeDefaultersList,
                    includePaymentInfo,
                    includeSecurityInfo,
                    includeFollowUpInfo,
                    includeBiddingInfo,
                    id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}

