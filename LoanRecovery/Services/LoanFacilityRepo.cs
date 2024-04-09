using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class LoanFacilityRepo:_AbsGenericRepo<LoanFacilities, int>, ILoanFacilitiesRepo
    {
        public LoanFacilityRepo(AppDbContext appDbContext):base(appDbContext)
        {
                
        }
    }
}
