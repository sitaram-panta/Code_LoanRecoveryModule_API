using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanSecuritiesController : GenericCRUDController<ILoanSecuritiesRepo, LoanSecurities, int>
    {
        public LoanSecuritiesController(ILoanSecuritiesRepo loanSecuritiesRepo):base(loanSecuritiesRepo) 
        {
                
        }
    }
}
