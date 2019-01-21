using System;
using System.Collections.Generic;

namespace ProAccount.Data.Models
{
    public partial class ChequeDetail
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public System.DateTime ChequeDate { get; set; }
        public string ChequeNo { get; set; }
        public string IFSCCode { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public virtual AccountTransaction AccountTransaction { get; set; }
    }
}
