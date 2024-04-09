using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;

namespace LoanRecovery.Services
{
    public class DefaulterRepo : _AbsGenericRepo<Defaulter, int>, IDefaulter
    {
        private readonly AppDbContext dbContext;

        public DefaulterRepo(AppDbContext _appDbContext) : base(_appDbContext)
        {

            dbContext = _appDbContext;
        }
        //public IQueryable<Defaulter> IncludeBrowwer(IQueryable<Defaulter> _Que)
        //{
        //    _Que = _Que.Include(x => x.LoanMembers.Select(y => y.GeneralCompanyPersonEntity));
        //    return _Que; 
        //}
        
    }
}
