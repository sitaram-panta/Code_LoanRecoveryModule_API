﻿using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanMemberController : GenericCRUDController<ILoanMemberRepo, LoanMembers, int>
    {
        public LoanMemberController(ILoanMemberRepo loanMemberRepo):base(loanMemberRepo) 
        {
                
        }
    }
}