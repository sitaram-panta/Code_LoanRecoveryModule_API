using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LoanFacilities:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }

        public string FacilityName { get; set; }
        public int LoanRefId { get; set; }

        //nav
        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
