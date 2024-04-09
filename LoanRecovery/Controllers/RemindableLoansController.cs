using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemindableLoansController : GenericCRUDController<IRemindableLoans, RemindableLoans, int>   
    {
        public RemindableLoansController(IRemindableLoans remindableLoans):base(remindableLoans) 
        {
                
        }
    }
}
