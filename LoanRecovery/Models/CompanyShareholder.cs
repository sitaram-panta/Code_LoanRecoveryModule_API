using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class CompanyShareholder: _AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public int CompanyInfoId { get; set; }

        [ForeignKey("CompanyInfoId"), JsonIgnore]
        public virtual CompanyInfo CompanyInfo { get; set; }
        public decimal SharePercent { get; set; }
        public DateTime RegdDate { get; set; }= DateTime.Now;
        public int GeneralId { get; set; }

        [ForeignKey("GeneralId"), JsonIgnore]
        public virtual GeneralCompanyPersonEntity GeneralCompanyPersonEntity { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;

               

    }
}
