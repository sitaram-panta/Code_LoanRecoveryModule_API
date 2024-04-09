using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class GeneralCompanyPersonEntity:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public bool IsCompany { get; set; }
        public int? CompanyInfoId { get; set; }
        public int? PersonInfoId { get; set; }
        public string DisplayName { get; set; }

        [ForeignKey("CompanyInfoId"), JsonIgnore]
        public virtual CompanyInfo CompanyInfo { get; set; }

        [ForeignKey("PersonInfoId"), JsonIgnore]
        public virtual PersonalInfo PersonalInfo { get; set; }

        [JsonIgnore]
        public virtual ICollection<LoanMembers> LoanMembers { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanGuaranters> LoanGuaranters { get; set; }
        [JsonIgnore]    
        public virtual ICollection<AuctionPayments> AuctionPayments { get; set; }
        [JsonIgnore]
        public virtual ICollection<AuctionBidder> AuctionBidders { get; set; }
        [JsonIgnore]
        public virtual ICollection<CompanyShareholder> CompanyShareholders { get; set; }



    }
}
