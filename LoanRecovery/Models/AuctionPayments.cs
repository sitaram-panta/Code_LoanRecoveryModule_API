using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class AuctionPayments:_AbsDefEntities
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public int BidderInfo { get; set; }
        public Decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CBSRefCode { get; set; }
        public string DigitalRefCopy { get; set; }

        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }

        [ForeignKey("BidderInfo"), JsonIgnore]
        public virtual GeneralCompanyPersonEntity GeneralCompanyPersonEntity { get; set; }
    }
}
