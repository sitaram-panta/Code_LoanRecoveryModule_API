using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LoanMembers:_AbsDefEntities
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public int GeneralId { get; set; }
        public bool IsPrimaryLoanee { get; set; }

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }

        [ForeignKey("GeneralId"), JsonIgnore]
        public virtual GeneralCompanyPersonEntity GeneralCompanyPersonEntity { get; set; }
    }
}
