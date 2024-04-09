using LoanRecovery.Enums;

namespace LoanRecovery.ViewModels
{
    public class LoanSecuritiesViewModel
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public SecurityType SecurityType { get; set; }
        public decimal FMV { get; set; }
        public decimal MV { get; set; }
    }
}
