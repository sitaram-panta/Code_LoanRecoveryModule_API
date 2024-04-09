using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class CompanyInfo:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string RegdNo { get; set; }
        public DateTime RegdDate { get; set; } = DateTime.Now;
        public String PanNo { get; set; }
        public String CreatedName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [JsonIgnore]
        public virtual ICollection<CompanyShareholder> CompanyShareholders { get; set; }
        public virtual ICollection<GeneralCompanyPersonEntity> General { get; set; }


    }
}
