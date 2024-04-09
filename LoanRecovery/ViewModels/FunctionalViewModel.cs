using LoanRecovery.Enums;

namespace LoanRecovery.ViewModels
{
    public class FunctionalViewModel
    {
        //public int LoanId { get; set; }
        //public string BorrowersName { get; set; }
        //public decimal LoanAmount { get; set; }
        //public decimal OsAmount { get; set; }
        //public decimal RepaymentAmount { get; set; }
        //public RepaymentType RepaymentType { get; set; }
        //public Status Status { get; set; }
        //public DateTime MaturityDate { get; set; }
        public List<DefaultersViewModel> DefaulterListView  { get; set; }
        public List<GuaranterViewModel> GuarantersListView  { get; set; }
        public List<PaymentViewModel> PaymentListView  { get; set; }
        public List<LoanSecuritiesViewModel> LoanSecurityView  { get; set; }
        public List<FollowUpViewModel> FollowUpView  { get; set; }
        public List<AuctionBidderViewModel> AuctionBidderView { get; set; }
    }
}
