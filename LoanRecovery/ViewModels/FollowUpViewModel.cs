using LoanRecovery.Enums;

namespace LoanRecovery.ViewModels
{
    public class FollowUpViewModel
    {
        public int Id { get; set; }
        public FollowUpType Type { get; set; }
        public DateTime FollowUpDate { get; set; } = DateTime.Now;
        public string FollowUpDetails { get; set; }
        public FollowUpStage Stage { get; set; }
        public string FollowedUpBy { get; set; }
        public int LoanRefId { get; set; }
        public string Name { get; set; }
    }
}
