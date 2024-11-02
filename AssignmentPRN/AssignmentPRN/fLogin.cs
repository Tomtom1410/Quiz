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
    public partial class fLogin : Form
    {
        Account curStudent = new Account();
        TestName curTest = new TestName();
        public fLogin()
        {
            InitializeComponent();

        }
        private bool checkLogin()
        {
            string testCode = tbTestName.Text;
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            if (TestDAO.getTestName(testCode) == null)
            {
                MessageBox.Show("Exam code is invalid!");
                return false;
            }
            else
            {
                curTest = TestDAO.getTestName(testCode);
            }

            if (AccountDAO.getAccount(username, password) == null)
            {
                MessageBox.Show("username or password is invalid!");
                return false;
            }
            else
            {
                curStudent = AccountDAO.getAccount(username, password);
            }

            if (AccountDAO.checkDoTest(curStudent.Id, curTest.Id))
            {
                MessageBox.Show("You taken this test!");
                return false;
            }
            return true;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                fTest fTest = new fTest();
                fTest.Student = curStudent;
                fTest.Test = curTest;
                this.Hide();
                fTest.ShowDialog();
                this.Close();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
