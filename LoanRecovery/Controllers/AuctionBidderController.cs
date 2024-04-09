using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionBidderController :GenericCRUDController<IAuctionBidder, AuctionBidder, int>
    {
        public AuctionBidderController(IAuctionBidder auctionBidder):base(auctionBidder)

        {
                
        }
    }
}
