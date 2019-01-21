using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAccount.Service.Account
{
    public class AccountService
    {
        public void SaveAccount(Data.Models.Account accountData)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                if (accountData.Id > 0)
                {
                    var data = db.Accounts.FirstOrDefault(W => W.Id == accountData.Id);
                    if (data != null)
                    {
                        data.FirmId = accountData.FirmId;
                        data.ContactName = accountData.ContactName;
                        data.ContactNo = accountData.ContactNo;
                        data.AccountCode = accountData.AccountCode;
                        data.AccountTypes = accountData.AccountTypes;
                        data.Address = accountData.Address;
                        data.Email = accountData.Email;
                        data.OpeningCredit = accountData.OpeningCredit;
                        data.OpeningDebit = accountData.OpeningDebit;
                        db.SaveChanges();
                    }
                }
                else
                {
                    db.Accounts.Add(new Data.Models.Account {
                    FirmId = accountData.FirmId,
                    ContactName = accountData.ContactName,
                    ContactNo = accountData.ContactNo,
                    AccountCode = accountData.AccountCode,
                    AccountTypes = accountData.AccountTypes,
                    Address = accountData.Address,
                    Email = accountData.Email,
                    OpeningCredit = accountData.OpeningCredit,
                    OpeningDebit = accountData.OpeningDebit
                });
                    db.SaveChanges();
                }
            }
        }

        public Data.Models.Account[] GetAccountByFirm(int firmId)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.Accounts.Where(w=>w.FirmId == firmId).OrderBy(o=>o.ContactName).ToArray();
            }
        }

        public Data.Models.Account GetAccountById(int Id)
        {
            using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
            {
                return db.Accounts.FirstOrDefault(w => w.Id == Id);
            }
        }

        public void DeleteAccountById(int Id)
        {
            using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
            {
                var data = db.Accounts.FirstOrDefault(W => W.Id == Id);
                if (data != null)
                {
                    db.Accounts.Remove(data);
                    db.SaveChanges();
                }
            }
        }

        public bool IsAccountExists(string Name)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                var data = db.Accounts.FirstOrDefault(W => W.ContactName == Name);
                if (data != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public bool IsAccountCodeExists(string AccountCode)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                var data = db.Accounts.FirstOrDefault(W => W.AccountCode == AccountCode);
                if (data != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public Data.Models.AccountType[] GetAccountType()
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.AccountTypes.OrderBy(o=>o.Type).ToArray();
            }
        }

        public Data.Models.Account GetAccountByName(string Name)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.Accounts.FirstOrDefault(w => Name.Contains(w.ContactName));
            }
        }

        public void SaveAccountType(Data.Models.AccountType accountType)
        {
            try
            {
                using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
                {
                    if (accountType.Id > 0)
                    {
                        var data = db.AccountTypes.FirstOrDefault(w => w.Id == accountType.Id);
                        if (data != null)
                        {
                            data.Type = accountType.Type;
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.AccountTypes.Add(new Data.Models.AccountType
                        {
                            Type = accountType.Type,
                        });
                        db.SaveChanges();
                    }
                }
            }
            catch(SqlException ex)
            {

            }
        }

        public Data.Models.AccountType GetAccountTypeById(int Id)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.AccountTypes.FirstOrDefault(w => w.Id == Id);
            }
        }

        public void DeleteAccountTypeById(int Id)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                var data = db.AccountTypes.FirstOrDefault(W => W.Id == Id);
                if (data != null)
                {
                    db.AccountTypes.Remove(data);
                    db.SaveChanges();
                }
            }
        }

        public bool IsAccountTypeExists(string Type)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                var data = db.AccountTypes.FirstOrDefault(W => W.Type == Type);
                if (data != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
