using System;
using System.Collections.Generic;

namespace ProAccount.Data.Models
{
    public partial class AccountTransaction
    {
        public AccountTransaction()
        {
            this.ChequeDetails = new List<ChequeDetail>();
        }

        public int Id { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int FirmId { get; set; }
        public int AccountId { get; set; }
        public string TransactionsType { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public virtual Account Account { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual ICollection<ChequeDetail> ChequeDetails { get; set; }
    }
}
