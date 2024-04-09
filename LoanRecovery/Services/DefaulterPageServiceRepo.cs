
using LoanRecovery.Data;
using LoanRecovery.Enums;
using LoanRecovery.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LoanRecovery.Services
{
    public class DefaulterPageServiceRepo
    {

        private readonly AppDbContext dbcontext;

       
        

        public DefaulterPageServiceRepo(AppDbContext _dbContext)
        {
            dbcontext = _dbContext;
        }

        public DefaulterPageServiceRepo()
        {
                
        }
        public virtual IQueryable<DefaultersViewModel> GetDefaulters()
        {
            try
            {
                var defaulterDataList =  dbcontext.Defaulters
                    .Include(x => x.LoanMembers)
                    .ToList().AsQueryable();

                if (defaulterDataList == null || !defaulterDataList.Any())
                {
                    throw new Exception("No Defaulters found");
                }

                var defaulterViewModelList = new List<DefaultersViewModel>();

                foreach (var defaulterData in defaulterDataList)
                {
                    var pin = defaulterData.LoanMembers.FirstOrDefault(x => x.IsPrimaryLoanee);
                    if (pin == null)
                    {
                        throw new Exception("Invalid Primary Loanee Information");
                    }

                    var c =  dbcontext.GeneralCompanyPersonEntities
                                    .Where(g => g.Id == pin.GeneralId)
                                    .FirstOrDefault();

                    var defaulterViewModel = new DefaultersViewModel
                    {
                        LoanId = defaulterData.Id,
                        BorrowersName = c.DisplayName,
                        LoanAmount = defaulterData.DisburshedAmount,
                        InterestRate = defaulterData.InterestRate,
                        OsAmount = defaulterData.OutstandingAmount,
                        RepaymentAmount = defaulterData.RepaymentAmount,
                        RepaymentType = defaulterData.RepaymentType,
                        Status = defaulterData.Status,
                        MaturityDate = defaulterData.MaturityDate
                    };

                    defaulterViewModelList.Add(defaulterViewModel);
                }

                return (defaulterViewModelList).AsQueryable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<DefaultersViewModel>> FilterDefaulter(
             DateTime? fromDate,
             DateTime? toDate,
             RepaymentType? repaymentType,
             Status? status,
             int? loanId)
        {
            try
            {
                if (fromDate == null && toDate == null && repaymentType == null && status == null && loanId == null)
                {
                    throw new Exception("At least one filter parameter should be provided.");
                }


                if (fromDate.HasValue && toDate.HasValue && fromDate > toDate)
                {
                    throw new Exception("Invalid data range: 'From Date' should be before or equal to 'To Date'");
                }

                var list = await dbcontext.Defaulters.Where(x => x.MaturityDate >= fromDate && x.MaturityDate <= toDate ||
                x.RepaymentType.Equals(repaymentType) ||
                x.Status == status ||
                x.Id == loanId)
                .ToListAsync();

                var data = new List<DefaultersViewModel>();

                foreach (var item in list)
                {
                    var pin = item.LoanMembers.FirstOrDefault(x => x.IsPrimaryLoanee);

                    if (pin == null)
                    {
                        throw new Exception("Invalid Primary Loanee Information");
                    }
                    var c = await dbcontext.GeneralCompanyPersonEntities.Where(p => p.Id == pin.GeneralId).FirstOrDefaultAsync();

                    var defaulterViewModel = new DefaultersViewModel
                    {
                        MaturityDate = item.MaturityDate,
                        RepaymentType = item.RepaymentType,
                        Status = item.Status,
                        LoanId = item.Id,
                        OsAmount = item.OutstandingAmount,
                        RepaymentAmount = item.RepaymentAmount,
                        LoanAmount = item.DisburshedAmount,
                        BorrowersName = c.DisplayName,
                        InterestRate = item.InterestRate,
                    };

                    data.Add(defaulterViewModel);
                }
                return (data);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public async Task<IEnumerable<GuaranterViewModel>> GuarantorInfo(int id)//Details part of the defaulter started from here
        {
            var Info = await dbcontext.LoanGuaranters.Where(x => x.LoanRefId == id).ToListAsync();
            var guaranterViewModel = new List<GuaranterViewModel>();
            foreach (var item in Info)
            {
                var viewModel = new GuaranterViewModel
                {
                    Id = item.Id,
                    GeneralId = item.GeneralId,
                    GuaranteePercent = item.GuaranteePercent
                };

                guaranterViewModel.Add(viewModel);

            }
            return (guaranterViewModel);

        }

        public async Task<IEnumerable<PaymentViewModel>> PaymentInfo(int id)
        {
            var paymentDataList = await dbcontext.LoanPaymentLogs
                    .Include(x => x.Defaulter)
                    .ToListAsync();
            if (paymentDataList == null || !paymentDataList.Any())
            {
                throw new Exception("No Payment Records Found");
            }

            var paymentViewModel = new List<PaymentViewModel>();
            foreach (var item in paymentDataList)
            {
                var viewModel = new PaymentViewModel
                {
                    Id = item.Id,
                    PaymentDate = item.PaymentDate,
                    PaymentAmount = item.PaymentAmount,
                    OutstandingPrincipal = item.OutstandingPrincipal,
                    DisburshedAmount = item.DisburshedAmount,
                    RemainingAmount = item.RemainingAmount,
                };
                paymentViewModel.Add(viewModel);
            }
            return (paymentViewModel);
        }

        public async Task<IEnumerable<PaymentViewModel>> FilterPaymentdetails(
          DateTime? fromDate,
          DateTime? toDate,
          int? id
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

            var list = await dbcontext.LoanPaymentLogs.
                Where(x => x.PaymentDate >= fromDate && x.PaymentDate <= toDate|| x.Id==id)
                
                .ToListAsync();

            var paymentDetails = new List<PaymentViewModel>();
            foreach (var item in list)
            {
                var viewModel = new PaymentViewModel
                {
                    Id = item.Id,
                    PaymentDate = item.PaymentDate,
                    PaymentAmount = item.PaymentAmount,
                    OutstandingPrincipal = item.OutstandingPrincipal,
                    DisburshedAmount = item.DisburshedAmount,
                    RemainingAmount = item.RemainingAmount
                };
                paymentDetails.Add(viewModel);
            }

            return (paymentDetails);

        }

        public async Task<IEnumerable<LoanSecuritiesViewModel>> LoanSecurityInfo(int id)
        {
            var securityDetails = await dbcontext.LoanSecurities.Where(x => x.LoanRefId == id).ToListAsync();
            var securityViewModel = new List<LoanSecuritiesViewModel>();

            foreach (var item in securityDetails)
            {
                var viewModel = new LoanSecuritiesViewModel
                {
                    Id = item.Id,
                    SecurityType = item.SecurityType,
                    FMV = item.MV,
                    MV = item.MV,
                };
                securityViewModel.Add(viewModel);
            }
            return (securityViewModel);
        }

        public async Task<IEnumerable<FollowUpViewModel>> FollowUpInfo(int id)
        {
            var followupDetails = await dbcontext.FollowUps.
             Include(x => x.Defaulter)
            .ToListAsync();

            if (followupDetails == null || !followupDetails.Any())
            {
                throw new Exception("No followup Records found");
            }

            var followUpViewModel = new List<FollowUpViewModel>();

            foreach (var item in followupDetails)
            {
                var viewModel = new FollowUpViewModel
                {
                    Id = item.Id,
                    Type = item.Type,
                    FollowedUpBy = item.FollowedUpBy,
                    FollowUpDate = item.FollowUpDate,
                    FollowUpDetails = item.FollowUpDetails,
                    Stage = item.Stage,
                };

                followUpViewModel.Add(viewModel);

            }
            return (followUpViewModel);

        }

        public async Task<IEnumerable<FollowUpViewModel>> FilterFollowUpdetails(
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

            var list = await dbcontext.FollowUps.
                Where(x => x.FollowUpDate >= fromDate && x.FollowUpDate <= toDate)
                .ToListAsync();

            var followupDetails = new List<FollowUpViewModel>();
            foreach (var item in list)
            {
                var viewModel = new FollowUpViewModel
                {
                    Id = item.Id,
                    Type = item.Type,
                    FollowUpDate=item.FollowUpDate,
                    FollowUpDetails=item.FollowUpDetails,
                    Stage = item.Stage,
                    FollowedUpBy = item.FollowedUpBy,
                };
                followupDetails.Add(viewModel);
            }

            return (followupDetails);

        }

        public async Task<IEnumerable<ReminderViewModel>> ReminderInfo(int id)
        {
            var reminderDetails = await dbcontext.LoanReminderLog.Where(x => x.LoanRefId == id).ToListAsync();

            var reminderViewModel = new List<ReminderViewModel>();
            foreach (var item in reminderDetails)
            {
                var viewModel = new ReminderViewModel
                {
                    Id = item.Id,
                    LoanRefId = item.LoanRefId,
                    Reminder = item.Reminder,
                    ReminderDate = item.ReminderDate,
                    Response = item.Response,
                    Remarks = item.Remarks,
                    HasNextReminderSchedule = item.HasNextReminderSchedule,
                    NextReminderDate = item.NextReminderDate,
                    CreatedDate = item.CreatedDate,
                    CreatedName = item.CreatedName
                };
                reminderViewModel.Add(viewModel);
            }

            return (reminderViewModel);
        }

        public async Task<IEnumerable<LegalNoticeViewModel>> LegalInfo(int id)
        {
            var legaldetails = await dbcontext.legalNoticeSentLogs.Where(x => x.LoanRefId == id).ToListAsync();

            var legalNoticeViewModel = new List<LegalNoticeViewModel>();
            foreach (var item in legaldetails)
            {
                var viewModel = new LegalNoticeViewModel
                {
                    Id = item.Id,
                    LoanRefId = item.LoanRefId,
                    SendDate = item.SendDate,
                    SendMedium = item.SendMedium,
                    DigitalCopyFile = item.DigitalCopyFile,
                    CreatedDate = item.CreatedDate,
                    CreatedName = item.CreatedName
                };

                legalNoticeViewModel.Add(viewModel);
            }

            return (legalNoticeViewModel);
        }

        public async Task<IEnumerable<AuctionBidderViewModel>> BiddingInfo(int id)
        {
            var info = await dbcontext.AuctionBidders.Where(X => X.LoanRefId == id).ToListAsync();
            var biddingInfo = new List<AuctionBidderViewModel>();
            foreach (var item in info)
            {
                var viewModel = new AuctionBidderViewModel
                {
                    Id = item.Id,
                    LoanRefId = item.LoanRefId,
                    BidDate = item.BidDate,
                    BidderAmount = item.BidderAmount,
                    BidderInfo = item.BidderInfo,
                    IsAwarded = item.IsAwarded
                };
                biddingInfo.Add(viewModel);
            }

            return (biddingInfo);

        }

        //Todo: loan Recovery is missing due to no table in the database
        public async Task<FunctionalViewModel> DetailsByFunctionalities(
         bool includeDefaultersList,
         bool includeGuarantorInfo,
         bool includePaymentInfo,
         bool includeSecurityInfo,
         bool includeFollowUpInfo,
         bool includeBiddingInfo,
         int? id = null)
        {
            var loanDetails = new FunctionalViewModel();

            if (!(includeDefaultersList || includeGuarantorInfo ||
                includePaymentInfo || includeSecurityInfo ||
                includeFollowUpInfo || includeBiddingInfo))
            {
                throw new Exception("At least one functionality should be selected.");
            }

            if (includeDefaultersList == true)
            {
                var defaulters = GetDefaulters();
                loanDetails.DefaulterListView = defaulters.ToList();
            }

            if (includeGuarantorInfo == true && id.HasValue) // Check if id has value
            {
                var guarantorInfo = await GuarantorInfo(id.Value); // Pass the id value
                loanDetails.GuarantersListView = guarantorInfo.ToList();
            }

            if (includePaymentInfo == true && id.HasValue) // Check if id has value
            {
                var paymentInfo = await PaymentInfo(id.Value); // Pass the id value
                loanDetails.PaymentListView = paymentInfo.ToList();
            }
            if (includeSecurityInfo == true && id.HasValue)
            {
                var securityInfo = await LoanSecurityInfo(id.Value);
                loanDetails.LoanSecurityView = securityInfo.ToList();

            }
            if (includeFollowUpInfo == true && id.HasValue)
            {
                var followUPInfo = await FollowUpInfo(id.Value);
                loanDetails.FollowUpView = followUPInfo.ToList();
            }
            if (includeBiddingInfo == true && id.HasValue)
            {
                var biddingInfo = await BiddingInfo(id.Value);
                loanDetails.AuctionBidderView = biddingInfo.ToList();

            }

            // Add other conditions to fetch more details based on other functionalities...

            return loanDetails;
        }

    }
}

