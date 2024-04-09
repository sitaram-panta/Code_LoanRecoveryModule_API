using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LoanPaymentLogRepo:_AbsGenericRepo<LoanPaymentLog, int>, ILoanPaymentLog
    {
        public LoanPaymentLogRepo(AppDbContext appDbContext):base(appDbContext)
        {
                
        }
    }
}
