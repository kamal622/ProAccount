using System;
using System.Collections.Generic;

namespace ProAccount.Data.Models
{
    public partial class Firm
    {
        public Firm()
        {
            this.Accounts = new List<Account>();
            this.AccountTransactions = new List<AccountTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; }
    }
}
