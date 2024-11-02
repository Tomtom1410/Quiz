using AssignmentPRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPRN.DAO
{
    public class AccountDAO
    {

        public static Account getAccount(string username, string password)
        {
            using (var context = new Assignment_PRNContext())
            {
                Account account = context.Accounts.FirstOrDefault
                    (x => x.Username.Equals(username) && x.Password.Equals(password));
                if (account != null)
                {
                    return account;
                }
            }
            return null;
        }

        public static bool checkDoTest(int accountId, int testId)
        {

            using (var context = new Assignment_PRNContext())
            {
                Result result = context.Results.FirstOrDefault(
                    x => x.AccountId == accountId && x.TestId == testId);  
                if (result != null) return true;
            }
            return false;
        }

    }
}
