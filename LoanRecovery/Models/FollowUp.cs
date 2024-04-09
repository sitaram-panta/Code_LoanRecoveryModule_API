using LoanRecovery.Enums;
using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class FollowUp:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public FollowUpType Type { get; set; }
        public DateTime FollowUpDate { get; set; }= DateTime.Now;
        public string FollowUpDetails { get; set; }
        public FollowUpStage Stage { get; set; }
        public string FollowedUpBy { get; set; }
        public int LoanRefId { get; set; }

        //nav
        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
