using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : GenericCRUDController<IBranchRepo, Branch, int>
    {
        public BranchController(IBranchRepo branchRepo):base(branchRepo) 
        {
                
        }
    }
}
