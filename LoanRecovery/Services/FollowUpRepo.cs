using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class FollowUpRepo:_AbsGenericRepo<FollowUp, int>, IFollowUpRepo
    {
        public FollowUpRepo(AppDbContext dbContext):base(dbContext) 
        {
                
        }
    }
}
