using LoanRecovery.Enums;
using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LegalNoticeSentLog
    {
        [Key]
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
        public SendMedium SendMedium { get; set; } 
        public string DigitalCopyFile { get; set; } 
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; 

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
