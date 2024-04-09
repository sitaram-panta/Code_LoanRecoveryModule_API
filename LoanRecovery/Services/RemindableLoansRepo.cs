using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class RemindableLoansRepo:_AbsGenericRepo<RemindableLoans, int>, IRemindableLoans
    {
        public RemindableLoansRepo(AppDbContext context):base(context) 
        {
                
        }
    }
}
