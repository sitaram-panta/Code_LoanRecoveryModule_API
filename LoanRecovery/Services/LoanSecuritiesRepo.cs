using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LoanSecuritiesRepo:_AbsGenericRepo<LoanSecurities, int>, ILoanSecuritiesRepo
    {
        public LoanSecuritiesRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
