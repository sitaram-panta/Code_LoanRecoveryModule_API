using LoanRecovery.Migrations.Models;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class AuctionBidder: _AbsDefEntities
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public int BidderInfo { get; set; }
        public int BidderAmount { get; set; }
        public DateTime BidDate { get; set; } = DateTime.Now;
        public bool IsAwarded { get; set; }

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }

        [ForeignKey("BidderInfo"), JsonIgnore]
        public virtual GeneralCompanyPersonEntity GeneralCompanyPersonEntity { get; set; }
    }
}