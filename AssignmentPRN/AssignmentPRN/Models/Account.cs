using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class Account
    {
        public Account()
        {
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
