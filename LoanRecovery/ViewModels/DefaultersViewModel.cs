﻿using LoanRecovery.Enums;

namespace LoanRecovery.ViewModels
{
    public class DefaultersViewModel
    {
        public int LoanId { get; set; }
        public string BorrowersName { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal OsAmount { get; set; }
        public decimal RepaymentAmount { get; set; }
        public decimal InterestRate { get; set; }
        public RepaymentType RepaymentType { get; set; }
        public Status Status { get; set; }
        public DateTime MaturityDate { get; set; }
    }
}
