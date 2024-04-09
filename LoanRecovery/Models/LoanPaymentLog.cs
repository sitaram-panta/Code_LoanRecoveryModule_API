using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LoanPaymentLog:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public decimal PaymentAmount { get; set; }
        public decimal DisburshedAmount { get; set; }
        public decimal OutstandingPrincipal { get; set; }
        public decimal RemainingAmount { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        //nav
        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
