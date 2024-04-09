using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Services
{
    public class PersonalInfoRepo : _AbsGenericRepo<PersonalInfo, int>, IpersonalInfoRepo
    {
        private readonly AppDbContext appDbContext;
        public PersonalInfoRepo(AppDbContext _appDbContext) : base(_appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public override async Task<PersonalInfo> Update(int id, PersonalInfo table)
        {

            var existingEntity = await base.Update(id, table);

            if (existingEntity != null)
            {
                var relatedGeneralEntity = await appDbContext.GeneralCompanyPersonEntities.
                 FirstOrDefaultAsync(x => x.PersonInfoId == id);

                if (relatedGeneralEntity != null)
                {
                    relatedGeneralEntity.DisplayName = existingEntity.FullName;
                    await appDbContext.SaveChangesAsync();
                }
            }
            return existingEntity;
        }
    }
}
