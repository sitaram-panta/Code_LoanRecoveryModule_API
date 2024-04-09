using LoanRecovery.Migrations.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class PersonalInfo:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public bool IsAlive { get; set; }
        public string NationalId { get; set; }
        public string CitizenshiipNO { get; set; }
        public string CitizenshipIssueDistrict { get; set; }
        public DateTime CitizenshipIssueData { get; set; }= DateTime.Now;
        public int? FatherInfoId { get; set; }
        public int? MotherInfoId { get; set; }
        public string CreatedName  { get; set; }
        public DateTime CreatedDate  { get; set; }=DateTime.Now;

        [ForeignKey("FatherInfoId"),JsonIgnore]
        public virtual PersonalInfo FatherInfo { get; set; }

        [ForeignKey("MotherInfoId"), JsonIgnore]
        public virtual PersonalInfo MotherInfo { get; set; }

        [JsonIgnore]
        public virtual ICollection<GeneralCompanyPersonEntity> generalCompanyPersonEntities { get; set; }

    }
}
