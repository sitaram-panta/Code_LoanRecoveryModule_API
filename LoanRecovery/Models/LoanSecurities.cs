using LoanRecovery.Enums;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LoanSecurities:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public SecurityType SecurityType { get; set; }
        public decimal FMV { get; set; }
        public decimal MV { get; set; }

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
