using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class Question
    {
        public Question()
        {
            CorrectAnswers = new List<CorrectAnswer>();
            Answers = new List<Answer>();
        }

        public int Qid { get; set; }
        public string QContent { get; set; }
        public int? TestId { get; set; }

        public virtual TestName Test { get; set; }

        public string QuestionShow
        {
            get
            {
                string content = QContent + "\n\n";
                foreach (var answer in Answers)
                {
                    content += answer.AnswerContent + "\n\n";
                }
                return content;
            }
        }


        public virtual List<Answer> Answers { get; set; }
        public virtual List<CorrectAnswer> CorrectAnswers { get; set; }
    }
}
