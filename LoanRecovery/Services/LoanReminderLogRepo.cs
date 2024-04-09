using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LoanReminderLogRepo:_AbsGenericRepo<LoanReminderLog,int>, ILoanReminderRepo
    {
        public LoanReminderLogRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
