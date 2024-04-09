using LoanRecovery.Data;
using LoanRecovery.Models;
using LoanRecovery.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Services
{
    public class FollowUpPageServiceRepo
    {
        private readonly AppDbContext dbContext;
        public FollowUpPageServiceRepo(AppDbContext _dbContext)
        {
            dbContext = _dbContext;

        }

        public async Task<IEnumerable<FollowUpViewModel>> DisplayFollowUps()
        {
            try
            {
                var followupList = await dbContext.FollowUps
                    .Include(x => x.Defaulter)
                    .ThenInclude(x => x.LoanMembers.Where(x => x.IsPrimaryLoanee))
                    .ToListAsync();
                if (followupList == null || !followupList.Any())
                {
                    throw new Exception("No Payment Records Found");
                }

                var followUpViewModel = new List<FollowUpViewModel>();
                foreach (var follow in followupList)
                {
                    var c = follow.Defaulter?.LoanMembers.FirstOrDefault();

                    if (c == null)
                    {
                        throw new Exception("Invalid Primary Loanee");
                    }

                    var value = dbContext.GeneralCompanyPersonEntities
                        .Where(a => a.Id == c.GeneralId).FirstOrDefault();
                    var ViewModel = new FollowUpViewModel
                    {
                        LoanRefId = follow.LoanRefId,
                        Name = value.DisplayName,
                        Type = follow.Type,
                        FollowUpDate = follow.FollowUpDate,
                        FollowUpDetails = follow.FollowUpDetails,
                        Stage = follow.Stage,
                        FollowedUpBy = follow.FollowedUpBy
                    };
                    followUpViewModel.Add(ViewModel);
                }
                return (followUpViewModel);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<FollowUpViewModel>> FilterFollowUp(
         DateTime? fromDate,
         DateTime? toDate
         )
        {
            if (fromDate == null && toDate == null)
            {

                throw new Exception("At least one filter parameter should be provided");
            }

            if (fromDate.HasValue && toDate.HasValue && fromDate > toDate)
            {
                throw new Exception("Invalid data range: 'From Date' should be before or equal to 'To Date'");
            }

            var list = await dbContext.FollowUps.
                Where(x => x.FollowUpDate >= fromDate && x.FollowUpDate <= toDate)
                .ToListAsync();

            var followupDetails = new List<FollowUpViewModel>();
            foreach (var item in list)
            {
                var c = item.Defaulter?.LoanMembers.FirstOrDefault();

                if (c == null)
                {
                    throw new Exception("Invalid Primary Loanee");
                }

                var value = dbContext.GeneralCompanyPersonEntities
                    .Where(a => a.Id == c.GeneralId).FirstOrDefault();

                var viewModel = new FollowUpViewModel
                {
                    LoanRefId = item.Id,
                    Type = item.Type,
                    Name = value.DisplayName,
                    FollowUpDate = item.FollowUpDate,
                    FollowUpDetails = item.FollowUpDetails,
                    Stage = item.Stage,
                    FollowedUpBy = item.FollowedUpBy,
                };
                followupDetails.Add(viewModel);
            }

            return (followupDetails);

        }

    }
}
