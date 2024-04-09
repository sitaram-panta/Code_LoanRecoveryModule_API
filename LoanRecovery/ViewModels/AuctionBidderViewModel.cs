namespace LoanRecovery.ViewModels
{
    public class AuctionBidderViewModel
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public int BidderInfo { get; set; }
        public int BidderAmount { get; set; }
        public DateTime BidDate { get; set; } = DateTime.Now;
        public bool IsAwarded { get; set; }

    }
}
