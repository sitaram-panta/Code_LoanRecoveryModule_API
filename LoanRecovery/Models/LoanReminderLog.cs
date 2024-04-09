using LoanRecovery.Enums;
using LoanRecovery.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class LoanReminderLog
    {
        [Key]
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public ReminderType Reminder { get; set; }
        public DateTime ReminderDate { get; set; } = DateTime.Now;
        public string Response { get; set; }
        public string Remarks { get; set; }
        public bool HasNextReminderSchedule { get; set; }
        public DateTime NextReminderDate { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }
    }
}
