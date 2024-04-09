using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class AuctionPaymentRepo:_AbsGenericRepo<AuctionPayments, int>, IAuctionPaymentsRepo
    {
        public AuctionPaymentRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
