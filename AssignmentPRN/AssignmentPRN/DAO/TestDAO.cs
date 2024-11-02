using AssignmentPRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPRN.DAO
{
    public class TestDAO
    {
        static Assignment_PRNContext context = new Assignment_PRNContext();

        public static TestName getTestName(string testCode)
        {
            TestName testName = context.TestNames.FirstOrDefault(x => x.TestCode == testCode);  
            return testName;
        }

        public static List<Question> GetQuestionsOfTest(int testId)
        {
            List<Question> questions = context.Questions.Where(x=> x.TestId == testId).ToList();

            foreach (Question q in questions)
            {
                int option = 65;
                List<Answer> answer = context.Answers.Where(x=> x.QuestionId == q.Qid).ToList();
                foreach(Answer ans in answer)
                {
                    ans.AnswerContent = (char)option+ ". " + ans.AnswerContent;
                    option++;
                }
                q.Answers = answer;

                q.CorrectAnswers = context.CorrectAnswers.Where(x => x.QuestionId == q.Qid).ToList();
            }
            return questions;
        }
    }
}
