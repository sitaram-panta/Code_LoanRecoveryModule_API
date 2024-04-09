using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LegalNoticeSentLogRepo:_AbsGenericRepo<LegalNoticeSentLog, int>, ILegalNoticeSentLog
    {
        public LegalNoticeSentLogRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
