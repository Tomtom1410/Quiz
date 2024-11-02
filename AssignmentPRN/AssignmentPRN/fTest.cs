using AssignmentPRN.DAO;
using AssignmentPRN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentPRN
{
    public partial class fTest : Form
    {
        List<Question> questions = new List<Question>();
        Dictionary<Question, List<char>> curAnswers = new Dictionary<Question, List<char>>();
        Timer TimeLeft;
        int hour;
        int counter = 0;
        int questionPossion = 0;
        public fTest()
        {
            InitializeComponent();

        }

        public TestName Test { get; set; }
        public Account Student { get; set; }



        private void fTest_Load(object sender, EventArgs e)
        {
            hour = Convert.ToInt32(Test.Duration);
            lbExamCode.Text = Test.TestCode;
            lbStudentName.Text = Student.Username;
            TimeLeft = new Timer();
            TimeLeft.Interval = 1000;
            DesignClock();
            TimeLeft.Start();
            TimeLeft.Tick += TimeLeft_Tick;
            questions = TestDAO.GetQuestionsOfTest(Test.Id);
            SetData();

        }
        private void DesignClock()
        {
            if (hour.ToString().Length == 1)
            {
                lbTimeLeft.Text = "0" + hour.ToString() + ":0" + counter.ToString();
                lbDuration.Text = "0" + Test.Duration.ToString() + " minutes";
            }
            else
            {
                lbTimeLeft.Text = hour.ToString() + ":0" + counter.ToString();
                lbDuration.Text = Test.Duration.ToString() + " minutes";
            }
        }
        private void TimeLeft_Tick(object sender, EventArgs e)
        {

            if (counter == 0)
            {
                counter = 60;
                if (hour == 0)
                {
                    TimeLeft.Stop();
                    FinishExam();
                }
                else
                {
                    hour--;
                }
            }
            else
            {
                counter--;
                if (counter.ToString().Length == 1)
                {
                    if (hour.ToString().Length == 1)
                        lbTimeLeft.Text = "0" + hour.ToString() + ":0" + counter.ToString();
                    else 
                        lbTimeLeft.Text = hour.ToString() + ":0" + counter.ToString();
                }
                else
                {
                    if (hour.ToString().Length == 1)
                        lbTimeLeft.Text = "0" + hour.ToString() + ":" + counter.ToString();
                    else
                        lbTimeLeft.Text = hour.ToString() + ":" + counter.ToString();
                }

            }
        }

        private void SetData()
        {
            lbNotic.Text = "Multiple choices " + (questionPossion + 1) + "/" + questions.Count + ":";

            rtbQuestion.Text = questions[questionPossion].QuestionShow;
            checkLbAns.Items.Clear();
            int pos = 65;
            foreach (Answer a in questions[questionPossion].Answers)
            {
                checkLbAns.Items.Add((char)pos);
                pos++;
            }

            if (curAnswers.ContainsKey(questions[questionPossion]))
            {
                foreach (char option in curAnswers[questions[questionPossion]])
                {
                    for (int i = 0; i < checkLbAns.Items.Count; i++)
                    {
                        if (option.ToString().Equals(checkLbAns.Items[i].ToString()))
                        {
                            checkLbAns.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (questionPossion == questions.Count - 1)
            {
                questionPossion = 0;
            }
            else
            {
                questionPossion++;
            }

            SetData();
        }

        private void GetAnswers()
        {
            List<char> options = new List<char>();
            options = checkLbAns.CheckedItems.Cast<char>().ToList();
            if (options.Count > 0)
            {
                if (curAnswers.Count == 0 || !curAnswers.ContainsKey(questions[questionPossion]))
                {
                    curAnswers.Add(questions[questionPossion], options);
                }
                else
                {
                    curAnswers.Remove(questions[questionPossion]);
                    curAnswers.Add(questions[questionPossion], options);
                }
            }
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            if (!cbFinish.Checked)
            {
                MessageBox.Show("You must tick in box [I want to finish exam.]! Please check it to confirm finish.");
            }
            else
            {
                TimeLeft.Stop();
                FinishExam();
            }
        }

        private void FinishExam()
        {

            Result checkInsert = null;
            using (var context = new Assignment_PRNContext())
            {
                Result result = new Result();
                result.TestId = Test.Id;
                result.Score = GetScore();
                result.AccountId = Student.Id;
                context.Results.Add(result);
                context.SaveChanges();
                checkInsert = result;
            }

            panel1.Hide();
            if (checkInsert != null)
            {
                label6.Text = "Submit successfull!";
                label6.Visible = true;
                cbFinish.Hide();
                btClose.Visible = true;
            }
            else
            {
                label6.Text = "Submit failed!";
                label6.Visible = true;
            }


        }

        private decimal GetScore()
        {
            int totalCorrect = 0;
            foreach (var answer in curAnswers) // check từng ques trong dictionary
            {
                int count = 0;
                foreach (Answer ca in answer.Key.Answers) // check answers của từng ques
                {
                    foreach (char ans in answer.Value) // duyệt mảng value user đã chọn
                    {
                        if (ca.AnswerContent.StartsWith(ans.ToString())) // nếu answer của ques bắt đầu = 1 value trong mảng
                        {                                     // thì lấy id của answer đó so sánh vs những correct answer
                            int id = ca.Id;                   // của ques
                            foreach (CorrectAnswer correct in answer.Key.CorrectAnswers)
                            {
                                if (correct.AnswerId == id) // nếu answer id = correct answer id thì count tăng
                                {
                                    count++;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (count == answer.Key.CorrectAnswers.Count) // nểu tổng count = tổng correct ans thì => user chọn 
                {                                             // đúng đáp án => 1 câu đúng
                    totalCorrect++;
                }
            }

            decimal score = (decimal)totalCorrect / questions.Count * 10;
            return score;
        }

        private void checkLbAns_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAnswers();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //fLogin login = (fLogin)Application.OpenForms["fLogin"];
            //login.Close();
        }
    }
}
