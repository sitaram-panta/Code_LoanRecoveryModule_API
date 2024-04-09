using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LoanMemberRepo:_AbsGenericRepo<LoanMembers, int>, ILoanMemberRepo
    {
        public LoanMemberRepo(AppDbContext appDbContext):base(appDbContext)
        {
                
        }
    }
}
