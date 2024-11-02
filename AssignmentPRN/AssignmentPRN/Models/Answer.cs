using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class Answer
    {
        public Answer()
        {
            CorrectAnswers = new HashSet<CorrectAnswer>();
        }

        public int Id { get; set; }
        public string AnswerContent { get; set; }
        public int? QuestionId { get; set; }

        public virtual ICollection<CorrectAnswer> CorrectAnswers { get; set; }
    }
}
