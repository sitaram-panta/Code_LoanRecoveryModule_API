using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class CompanyShareholderRepo:_AbsGenericRepo<CompanyShareholder, int>, ICompanyShareholderRepo
    {
        public CompanyShareholderRepo(AppDbContext appDbContext):base(appDbContext) 
        {
                
        }
    }
}
