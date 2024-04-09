using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfoController :GenericCRUDController<IpersonalInfoRepo, PersonalInfo, int>
    {
        public PersonalInfoController(IpersonalInfoRepo ipersonalInfoRepo):base(ipersonalInfoRepo) 
        {
                
        }
    }
}
