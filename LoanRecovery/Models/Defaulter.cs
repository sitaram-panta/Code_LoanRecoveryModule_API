using LoanRecovery.Enums;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class Defaulter:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public string LoanCamId { get; set; }
        public decimal DisburshedAmount { get; set; }
        public decimal OutstandingPrincipal { get; set; }
        public decimal DuePrincipal { get; set; }
        public decimal DueInterest { get; set; }
        public decimal AccuredInterest { get; set; }
        [NotMapped]
        public decimal OutstandingAmount => OutstandingPrincipal + DuePrincipal + AccuredInterest + DueInterest;
        public decimal InterestRate { get; set; }
        public bool Isonhold { set; get; }
        public RepaymentType RepaymentType { get; set; }
        public decimal RepaymentAmount { get; set; }
        public DateTime MaturityDate { get; set; }
        public Status Status { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int BranchId { get; set; }

        [ForeignKey("BranchId"), JsonIgnore]
        public virtual Branch Branch { get; set; }

        //nav
        [JsonIgnore]
        public virtual ICollection<LoanFacilities> LoanFacilities { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanPaymentLog> LoanPaymentLogs { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanSecurities> LoanSecurities { get; set; }
        [JsonIgnore]
        public virtual ICollection<RemindableLoans> RemindableLoans { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanReminderLog> LoanReminderLogs { get; set; }
        [JsonIgnore]
        public virtual ICollection<AuctionableLoans> AuctionableLoans { get; set; }
        [JsonIgnore]
        public virtual ICollection<LegalNoticeableLoans> LegalNoticeableLoans { get; set; }
        [JsonIgnore]
        public virtual ICollection<LegalNoticeSentLog> LegalNoticeSentLogs { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanMembers> LoanMembers { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanGuaranters> LoanGuaranters { get; set; }
        [JsonIgnore]
        public virtual ICollection<AuctionPayments> AuctionPayments { get; set; }
        [JsonIgnore]
        public virtual ICollection<AuctionBidder> AuctionBidders { get; set; }
        [JsonIgnore]
        public virtual ICollection<FollowUp> FollowUps { get; set; }

    }
}
