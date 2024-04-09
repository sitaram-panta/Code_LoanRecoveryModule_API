using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyShareholderController :GenericCRUDController<ICompanyShareholderRepo, CompanyShareholder, int>
    {
        public CompanyShareholderController(ICompanyShareholderRepo companyShareholderRepo):base(companyShareholderRepo) 
        {
                
        }
    }
}
