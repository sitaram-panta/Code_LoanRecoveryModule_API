using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LegalNoticeableLoanRepo:_AbsGenericRepo<LegalNoticeableLoans, int>, ILegalNoticeableLoansRepo
    {
        public LegalNoticeableLoanRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
