using LoanRecovery.Enums;

namespace LoanRecovery.ViewModels
{
    public class LegalNoticeViewModel
    {
        public int Id { get; set; }
        public int LoanRefId { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
        public SendMedium SendMedium { get; set; }
        public string DigitalCopyFile { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
