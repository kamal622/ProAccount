using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAccount.Service.Model
{
    public class AccountResultModel
    {
        public int Id { get; set; }
        //public int FirmId { get; set; }
        //public int AccountTypes { get; set; }
        public string FirmName { get; set; }
        public string ContactName { get; set; }
        public string AccountCode { get; set; }
        public string Type { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> OpeningDebit { get; set; }
        public Nullable<decimal> OpeningCredit { get; set; }
    }
}
