using System;
using System.Collections.Generic;

namespace ProAccount.Data.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            this.Accounts = new List<Account>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
