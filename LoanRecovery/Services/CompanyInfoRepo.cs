using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Services
{
    public class CompanyInfoRepo : _AbsGenericRepo<CompanyInfo, int>, ICompanyInfoRepo
    {
        private readonly AppDbContext appDbContext;
        public CompanyInfoRepo(AppDbContext _appDbContext) : base(_appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public override async Task<CompanyInfo> Update(int id, CompanyInfo table)
        {

            var existingEntity = await base.Update(id, table); 

            if (existingEntity != null)
            {
                var relatedGeneralEntity = await appDbContext.GeneralCompanyPersonEntities.
                    FirstOrDefaultAsync(x => x.CompanyInfoId == id);


                if (relatedGeneralEntity != null)
                {
                    relatedGeneralEntity.DisplayName = existingEntity.CompanyName;
                    await appDbContext.SaveChangesAsync();
                }
            }
            return existingEntity;
        }
    }
}
