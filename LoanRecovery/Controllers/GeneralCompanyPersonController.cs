using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using LoanRecovery.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralCompanyPersonController : GenericCRUDController<IGeneralCompanyPersonEntity, GeneralCompanyPersonEntity, int>
    {
       // private readonly GeneralCompanyPersonRepo repo;
        public GeneralCompanyPersonController(IGeneralCompanyPersonEntity generalCompanyPersonEntity
           // GeneralCompanyPersonRepo _repo
            ) : base(generalCompanyPersonEntity)

        {
            //repo = _repo;
        }

        //[HttpPost("updateDisplayName")]
        //public async Task<IActionResult> UpdateDisplayName([FromBody] GeneralCompanyPersonEntity entity)
        //{
        //    try
        //    {
        //        var nameInfo = await repo.Create(entity);
        //        return Ok (nameInfo);
               

        //    }
        //    catch (Exception ex)
        //    {

        //        return StatusCode(500, $"Internal Server error:{ex.Message}");
        //    }


        //}

    }
}
