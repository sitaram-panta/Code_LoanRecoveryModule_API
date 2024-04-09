using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Interfaces
{
    public interface ILoanReminderRepo: _IAbsGenericRepo<LoanReminderLog, int>
    {
    }
}
