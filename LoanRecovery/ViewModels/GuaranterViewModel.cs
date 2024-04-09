namespace LoanRecovery.ViewModels
{
    public class GuaranterViewModel
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public int GeneralId { get; set; }
        public Decimal GuaranteePercent { get; set; }
    }
}
