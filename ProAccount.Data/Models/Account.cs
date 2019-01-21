using System;
using System.Collections.Generic;

namespace ProAccount.Data.Models
{
    public partial class Account
    {
        public Account()
        {
            this.AccountTransactions = new List<AccountTransaction>();
        }

        public int Id { get; set; }
        public int FirmId { get; set; }
        public int AccountTypes { get; set; }
        public string AccountCode { get; set; }
        public string ContactName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> OpeningDebit { get; set; }
        public Nullable<decimal> OpeningCredit { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; }
    }
}
