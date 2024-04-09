using LoanRecovery.Controllers;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;

namespace LoanRecovery.Interfaces
{
    public interface ILoanSecuritiesRepo: _IAbsGenericRepo<LoanSecurities, int>
    {
    }
}
