using LoanRecovery.Enums;
using System.ComponentModel.DataAnnotations;

namespace LoanRecovery.ViewModels
{
    public class PaymentViewModel
    {
        public int Id { get; set; } 
        public int LoanRefId { get; set; }
        public string Name { get; set; }
        public LoanType LoanType { get; set; }
        public PaymentType paymentType { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public decimal PaymentAmount { get; set; }
        public decimal DisburshedAmount { get; set; }
        public decimal OutstandingPrincipal { get; set; }
        public decimal RemainingAmount { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
