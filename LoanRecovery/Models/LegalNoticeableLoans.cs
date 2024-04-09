using LoanRecovery.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LegalNoticeableLoans
    {
        [Key]
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public NoticeStage NoticeStage{ get; set; }
        public String CreatedName{ get; set; }
        public DateTime Created { get; set; } = DateTime.Now;


        [ForeignKey("LoanRefId"), JsonIgnore]
        public Defaulter Defaulter { get; set; }
    }
}
