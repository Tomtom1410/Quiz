using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class TestName
    {
        public TestName()
        {
            Questions = new HashSet<Question>();
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }
        public string TestCode { get; set; }
        public int? Duration { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
