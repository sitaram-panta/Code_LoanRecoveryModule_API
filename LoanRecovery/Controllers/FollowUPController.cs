using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowUPController : GenericCRUDController<IFollowUpRepo, FollowUp, int>
    {
        public FollowUPController(IFollowUpRepo repo) : base(repo)
        {

        }
    }
}
