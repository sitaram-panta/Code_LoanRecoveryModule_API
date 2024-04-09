using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanGuaranterController : GenericCRUDController<ILoanGuaranterRepo, LoanGuaranters, int>
    {
        public LoanGuaranterController(ILoanGuaranterRepo loanGuaranterRepo):base(loanGuaranterRepo)
        {
                
        }
    }
}
