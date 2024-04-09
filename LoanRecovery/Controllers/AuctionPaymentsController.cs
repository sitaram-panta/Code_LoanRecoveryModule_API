using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionPaymentsController : GenericCRUDController<IAuctionPaymentsRepo, AuctionPayments, int>
    {
        public AuctionPaymentsController(IAuctionPaymentsRepo auctionPaymentsRepo):base(auctionPaymentsRepo)
        {
                
        }
    }
}
