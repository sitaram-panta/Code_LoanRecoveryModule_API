using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class AuctionBidderRepo:_AbsGenericRepo<AuctionBidder, int>, IAuctionBidder
    {
        public AuctionBidderRepo(AppDbContext appDbContext) : base(appDbContext)
        {
                
        }
    }
}
