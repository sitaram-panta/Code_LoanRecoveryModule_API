using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class AuctionableLoanRepo:_AbsGenericRepo<AuctionableLoans, int>, IAuctionableRepo
    {
        public AuctionableLoanRepo(AppDbContext context):base(context) 
        {
                
        }
    }
}
