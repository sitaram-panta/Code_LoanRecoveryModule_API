using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class BranchRepo: _AbsGenericRepo<Branch, int>, IBranchRepo
    {
        public BranchRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
