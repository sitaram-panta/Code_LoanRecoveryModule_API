using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfoController : GenericCRUDController<ICompanyInfoRepo, CompanyInfo, int>
    {
        public CompanyInfoController(ICompanyInfoRepo companyInfoRepo):base(companyInfoRepo)
        {
                
        }
    }
}
