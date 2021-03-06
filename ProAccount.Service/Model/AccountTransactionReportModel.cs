﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAccount.Service.Model
{
    public class AccountTransactionReportModel
    {
        public int Id { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string FirmName { get; set; }
        public string AccountName { get; set; }
        public string TransactionsType { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public decimal? OpeningCredit { get; set; }
        public decimal? OpeningDebit { get; set; }
        public decimal? Balance { get; set; }
    }
}
