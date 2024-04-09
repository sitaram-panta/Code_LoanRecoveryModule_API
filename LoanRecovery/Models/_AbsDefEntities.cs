namespace LoanRecovery.Migrations.Models
{
    public class _AbsDefEntities
    {
        public bool IsStatus { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedName { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string UpdatedName { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
