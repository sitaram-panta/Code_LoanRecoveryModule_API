using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LoanGuaranterRepo:_AbsGenericRepo<LoanGuaranters, int>, ILoanGuaranterRepo
    {
        public LoanGuaranterRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
