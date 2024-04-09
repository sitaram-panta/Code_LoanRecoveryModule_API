using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class RemindableLoans
    {
        [Key]
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public DateTime ReminderStartDate { get; set; } = DateTime.Now;
        public DateTime ReminderEndDate { get; set; } = DateTime.Now;
        public bool HasDisableReminder { get; set; }  
        public string CreatedName { get; set; }  
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
