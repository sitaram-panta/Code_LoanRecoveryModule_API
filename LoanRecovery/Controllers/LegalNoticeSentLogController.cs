using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalNoticeSentLogController : GenericCRUDController<ILegalNoticeSentLog, LegalNoticeSentLog, int>
    {
        public LegalNoticeSentLogController(ILegalNoticeSentLog legalNoticeSentLog):base(legalNoticeSentLog)
        {
                
        }
    }
}
