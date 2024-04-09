using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LoanGuaranters:_AbsDefEntities
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public int GeneralId { get; set; }
        public Decimal GuaranteePercent { get; set; }

        [ForeignKey("LoanRefId"),JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }

        [ForeignKey("GeneralId"), JsonIgnore]
        public virtual GeneralCompanyPersonEntity GeneralCompanyPersonEntity { get; set; }    
    }
}
