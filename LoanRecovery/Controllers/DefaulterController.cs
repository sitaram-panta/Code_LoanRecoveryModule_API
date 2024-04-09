using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using LoanRecovery.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaulterController : GenericCRUDController<IDefaulter, Defaulter, int>
    {
        public DefaulterController(IDefaulter defaulter):base(defaulter) 
        {
           
                
        }

        
    }
}
