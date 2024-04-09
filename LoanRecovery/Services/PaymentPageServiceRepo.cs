using LoanRecovery.Data;
using LoanRecovery.Models;
using LoanRecovery.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Services
{
    public class PaymentPageServiceRepo
    {

        private readonly AppDbContext dbContext;
        public PaymentPageServiceRepo(AppDbContext _dbContext)
        {
            dbContext = _dbContext;

        }

        public async Task<IEnumerable<PaymentViewModel>> DisplayPayments()
        {
            try
            {
                var paymentDataList = await dbContext.LoanPaymentLogs
                    .Include(x => x.Defaulter)
                    .ThenInclude(x => x.LoanMembers.Where(x => x.IsPrimaryLoanee))
                    .ToListAsync();
                if (paymentDataList == null || !paymentDataList.Any())
                {
                    throw new Exception("No Payment Records Found");
                }


                var paymentViewModel = new List<PaymentViewModel>();
                foreach (var payment in paymentDataList)
                {
                    var c = payment.Defaulter?.LoanMembers.FirstOrDefault();

                    if (c == null)
                    {
                        throw new Exception("Invalid Primary Loanee");
                    }

                    var value = dbContext.GeneralCompanyPersonEntities
                        .Where(a => a.Id == c.GeneralId).FirstOrDefault();

                    var ViewModel = new PaymentViewModel
                    {
                        Id = payment.Id,
                        LoanRefId = payment.LoanRefId,
                        Name = value.DisplayName,
                        LoanType = (Enums.LoanType)1,
                        DisburshedAmount = payment.DisburshedAmount,
                        PaymentAmount = payment.PaymentAmount,
                        RemainingAmount = payment.RemainingAmount,
                        PaymentDate = payment.PaymentDate
                    };
                    paymentViewModel.Add(ViewModel);
                }
                return (paymentViewModel);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<IEnumerable<PaymentViewModel>> FilterPaymentdetails(
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

            var list = await dbContext.LoanPaymentLogs.
                Where(x => x.PaymentDate >= fromDate && x.PaymentDate <= toDate)
                .ToListAsync();

            var paymentDetails = new List<PaymentViewModel>();
            foreach (var item in list)
            {
                var c = item.Defaulter?.LoanMembers.FirstOrDefault();

                if (c == null)
                {
                    throw new Exception("Invalid Primary Loanee");
                }

                var value = dbContext.GeneralCompanyPersonEntities
                    .Where(a => a.Id == c.GeneralId).FirstOrDefault();
                var viewModel = new PaymentViewModel
                {
                    Id = item.Id,
                    PaymentDate = item.PaymentDate,
                    PaymentAmount = item.PaymentAmount,
                    OutstandingPrincipal = item.OutstandingPrincipal,
                    DisburshedAmount = item.DisburshedAmount,
                    RemainingAmount = item.RemainingAmount,
                    Name = value.DisplayName
                };
                paymentDetails.Add(viewModel);
            }

            return (paymentDetails);

        }
    }
}
