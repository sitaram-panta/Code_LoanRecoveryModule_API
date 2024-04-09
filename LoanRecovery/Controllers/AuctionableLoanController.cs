using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionableLoanController : GenericCRUDController<IAuctionableRepo,AuctionableLoans, int >
    {
        public AuctionableLoanController(IAuctionableRepo auctionableRepo):base(auctionableRepo) 

        {
                
        }
    }
}
