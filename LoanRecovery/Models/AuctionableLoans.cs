using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class AuctionableLoans:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public DateTime AuctionStartDate { get; set; }= DateTime.Now;
        public DateTime AuctionEndDate { get; set; }=DateTime.Now;
        public Decimal MinAuctionAmount { get; set; }
        public int LoanRefId { get; set; }


        [ForeignKey("LoanRefId"), JsonIgnore]
        public virtual Defaulter Defaulter { get; set; }

    }
}
