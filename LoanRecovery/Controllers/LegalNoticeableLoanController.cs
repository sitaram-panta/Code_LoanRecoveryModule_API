using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalNoticeableLoanController : GenericCRUDController<ILegalNoticeableLoansRepo, LegalNoticeableLoans, int>
    {
        public LegalNoticeableLoanController(ILegalNoticeableLoansRepo legalNoticeableLoansRepo):base(legalNoticeableLoansRepo)
        {
                
        }
    }
}
