namespace LoanRecovery.Enums
{
    public enum EnumApplicationUserType
    {
        SuperAdmin,
        SystemAdmin,
        SystemUsers
    }

    //public enum Frequency
    //{
    //    Quartely,
    //    Monthly
    //}

    public enum PaymentType
    {
        Paid,
        Late,
        Pending
    }

    public enum Stage
    {

        General,
        Biding,
        FinalRecovery,
        LegalAction
    }

    public enum DepartmentType
    {
        Sales,
        Finance,
        Operations,
        HR,
        Marketing
    }

    public enum BranchType
    {
        Kathmandu,
        Lalitpur,
        Bhaktapur

    }
    public enum Status
    {
        General,
        Biding,
        FinalRecovery,
        LegalAction,
        Cleared


    }
    public enum SecurityType
    {


    }

    public enum ReminderType
    {



    }

    public enum NoticeStage
    {


    }
    public enum SendMedium
    {



    }

    public enum RepaymentType
    {
        Quarterly,
        Monthly


    }
     public enum LoanType
    {
        EducationLoan,
        BusinessLoan,
        HomeLoan

    } 
    
    public enum FollowUpType
    {
        Email,
        Meeting,
        Phonecall,
        PhysicalMeet
    }
    public enum FollowUpStage
    {
        General,
        First,
        Second,
        Third
    }

    public enum LoanFunctionality
    {
        DefaultersList,
        GuarantorInfo,
        PaymentInfo,
        LoanSecurityInfo,
        FollowUpInfo,
        ReminderInfo,
        LegalInfo,
        BiddingInfo
    }


}
