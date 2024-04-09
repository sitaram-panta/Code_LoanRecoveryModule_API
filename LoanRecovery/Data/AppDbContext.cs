using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        }
        //Dbset

        public DbSet<OTPVerificationLog> OTPVerificationLogs { get; set; }
        public DbSet<Defaulter> Defaulters { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<FollowUp> FollowUps { get; set; }
        public DbSet<LoanFacilities> LoanFacilities { get; set; }
        public DbSet<LoanPaymentLog> LoanPaymentLogs { get; set; }
        public DbSet<LoanSecurities> LoanSecurities { get; set; }
        public DbSet<LoanGuaranters> LoanGuaranters { get; set; }
        public DbSet<LoanReminderLog> LoanReminderLog  { get; set; }
        public DbSet<RemindableLoans> RemindableLoans  { get; set; }
        public DbSet<LegalNoticeableLoans> LegalNoticeableLoans  { get; set; }
        public DbSet<LegalNoticeSentLog> legalNoticeSentLogs  { get; set; }
        public DbSet<PersonalInfo> PersonalInfos  { get; set; }
        public DbSet<CompanyInfo> CompanyInfos  { get; set; }
        public DbSet<GeneralCompanyPersonEntity> GeneralCompanyPersonEntities  { get; set; }
        public DbSet<LoanMembers> LoanMembers  { get; set; }
        public DbSet<AuctionPayments> AuctionPayments  { get; set; }
        public DbSet<AuctionableLoans> AuctionableLoans  { get; set; }
        public DbSet<AuctionBidder> AuctionBidders  { get; set; }
        public DbSet<CompanyShareholder> CompanyShareholders  { get; set; }


       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
