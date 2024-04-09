using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Services
{
    public class GeneralCompanyPersonRepo : _AbsGenericRepo<GeneralCompanyPersonEntity, int>, IGeneralCompanyPersonEntity
    {
        private readonly AppDbContext appDbContext;
       // private readonly CompanyInfoRepo companyInfoRepo;
       // private readonly PersonalInfoRepo personalInfoRepo;
        public GeneralCompanyPersonRepo(AppDbContext _appDbContext
            //CompanyInfoRepo _companyInfoRepo,
            //PersonalInfoRepo _personalInfoRepo
           ) : base(_appDbContext)
        {
            appDbContext = _appDbContext;
          // companyInfoRepo = _companyInfoRepo;
           // personalInfoRepo = _personalInfoRepo;


        }

        public override async Task<GeneralCompanyPersonEntity> Create(GeneralCompanyPersonEntity table)
        {
            if (table != null)
            {
                if (table.IsCompany == true)
                {
                    var compInfo = await appDbContext.CompanyInfos.FirstOrDefaultAsync(); 
                    table.DisplayName = compInfo.CompanyName;
                }
                else
                {
                    var perInfo = await appDbContext.PersonalInfos.FirstOrDefaultAsync();
                    table.DisplayName = perInfo.FullName;
                }

            }
            return await base.Create(table);
        }

        //public override async Task<GeneralCompanyPersonEntity> Update(int id, GeneralCompanyPersonEntity updatedEntity)
        //{
        //    var existingEntity = await appDbContext.GeneralCompanyPersonEntities  // can be used with uncommenting if requires this logic
        //        .Include(e => e.CompanyInfo)
        //        .Include(e => e.PersonalInfo)
        //        .FirstOrDefaultAsync(e => e.Id == id);

        //    if (existingEntity != null)
        //    {
        //        // Update DisplayName in GeneralCompanyPersonEntity
        //        existingEntity.DisplayName = updatedEntity.DisplayName;

        //        // Update related entity based on the entity type
        //        if (existingEntity.IsCompany)
        //        {
        //            var compInfo = existingEntity.CompanyInfo;
        //            if (compInfo != null)
        //            {
        //                compInfo.CompanyName = updatedEntity.DisplayName;
        //                appDbContext.Entry(compInfo).State = EntityState.Modified; // Mark CompanyInfo as modified
        //            }
        //        }
        //        else
        //        {
        //            var perInfo = existingEntity.PersonalInfo;
        //            if (perInfo != null)
        //            {
        //                perInfo.FullName = updatedEntity.DisplayName;
        //                appDbContext.Entry(perInfo).State = EntityState.Modified; // Mark PersonalInfo as modified
        //            }
        //        }

        //        // Save changes to DisplayName and related entities
        //        await appDbContext.SaveChangesAsync();
        //    }

        //    // Call the base repository's Update method to handle common update logic
        //    return await base.Update(id, existingEntity);
        //}


    }
}
