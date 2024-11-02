using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class CorrectAnswer
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual Question Question { get; set; }
    }
}
