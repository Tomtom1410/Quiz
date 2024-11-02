using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class Result
    {
        public int AccountId { get; set; }
        public int TestId { get; set; }
        public decimal? Score { get; set; }

        public virtual Account Account { get; set; }
        public virtual TestName Test { get; set; }
    }
}
