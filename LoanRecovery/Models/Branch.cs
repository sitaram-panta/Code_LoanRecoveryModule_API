using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanRecovery.Models
{
    public class Branch:_AbsDefEntities
    {
        [Key]
        public int Id { get; set; }
        public string BranchName { get; set; }

        // nav
        [JsonIgnore]
        public virtual ICollection<Defaulter> Defaulters { get; set; }
    }

}
