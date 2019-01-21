using ProAccount.Service.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProAccount.Service.AccountTransaction
{
    public class AccountTransactionService
    {
        public void SaveTransaction(Data.Models.AccountTransaction datamodel ,Data.Models.ChequeDetail chequeData)
        {
            try
            {
                using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
                {
                    if (datamodel.Id > 0)
                    {
                        var existingdata = db.AccountTransactions.FirstOrDefault(W => W.Id == datamodel.Id);
                        if (existingdata != null)
                        {
                            existingdata.FirmId = datamodel.FirmId;
                            existingdata.AccountId = datamodel.AccountId;
                            existingdata.TransactionDate = datamodel.TransactionDate;
                            existingdata.TransactionsType = datamodel.TransactionsType;
                            existingdata.Amount = datamodel.Amount;
                            existingdata.PaymentType = datamodel.PaymentType;
                            existingdata.Remarks = datamodel.Remarks;
                        }
                        db.SaveChanges();
                        if (chequeData != null && datamodel.PaymentType == "Cheque")
                        {
                            db.ChequeDetails.Add(new Data.Models.ChequeDetail
                            {
                                TransactionId = datamodel.Id,
                                BankName = chequeData.BankName,
                                ChequeNo = chequeData.ChequeNo,
                                IFSCCode = chequeData.IFSCCode,
                                ChequeDate = chequeData.ChequeDate
                            });
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        if (datamodel != null)
                        {
                            var transaction = db.AccountTransactions.Add(new Data.Models.AccountTransaction
                            {
                                TransactionDate = datamodel.TransactionDate,
                                FirmId = datamodel.FirmId,
                                AccountId = datamodel.AccountId,
                                TransactionsType = datamodel.TransactionsType,
                                Amount = datamodel.Amount,
                                PaymentType = datamodel.PaymentType,
                                Remarks = datamodel.Remarks
                            });
                            db.SaveChanges();

                            if (chequeData != null && datamodel.PaymentType == "Cheque")
                            {
                                db.ChequeDetails.Add(new Data.Models.ChequeDetail
                                {
                                    TransactionId = transaction.Id,
                                    BankName=chequeData.BankName,
                                    ChequeNo=chequeData.ChequeNo,
                                    IFSCCode=chequeData.IFSCCode,
                                    ChequeDate=chequeData.ChequeDate
                                });
                                db.SaveChanges();
                            }

                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }
        }

        public void DeleteTransactionById(int Id)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                var data = db.AccountTransactions.FirstOrDefault(w => w.Id == Id);
                if (data != null)
                {
                    if(data.PaymentType == "Cheque")
                    {
                        var chequeuData = db.ChequeDetails.FirstOrDefault(w => w.TransactionId == Id);
                        db.ChequeDetails.Remove(chequeuData);
                        db.SaveChanges();
                    }
                    db.AccountTransactions.Remove(data);
                    db.SaveChanges();
                }
            }
        }

        public Data.Models.AccountTransaction GetTransactionById(int Id)
        {
            try
            {
                using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
                {
                    return db.AccountTransactions.FirstOrDefault(w => w.Id == Id);
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<AccountTransactionResultModel> GetTodayTransactionData(int FirmId,int AccountId,DateTime transactionDate)
        {
            try
            {
                using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
                {
                    var todayData = from a in db.AccountTransactions
                                    where a.FirmId == FirmId && a.AccountId == AccountId
                                    && a.TransactionDate.Year == transactionDate.Year
                                    && a.TransactionDate.Month == transactionDate.Month
                                    && a.TransactionDate.Day == transactionDate.Day
                                    orderby a.TransactionDate descending
                                    select new AccountTransactionResultModel
                                    {
                                        Id=a.Id,
                                        FirmName=a.Firm.Name,
                                        AccountName=a.Account.ContactName,
                                        Amount=a.Amount,
                                        TransactionsType=a.TransactionsType,
                                        PaymentType=a.PaymentType,
                                        TransactionDate=a.TransactionDate,
                                        Remarks=a.Remarks
                                    };
                    return todayData.ToList();
                }
            }
            catch(SqlException ex)
            {
                return null;
            }
        }

        public List<AccountTransactionResultModel> GetAllTransactionData(int FirmId, int AccountId,DateTime toDate, DateTime fromDate)
        {
            try
            {
                using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
                {
                    var todayData = from a in db.AccountTransactions
                                    where a.TransactionDate.Year >= fromDate.Year
                                    && a.TransactionDate.Month >= fromDate.Month
                                    && a.TransactionDate.Day >= fromDate.Day
                                    && a.TransactionDate.Year <= toDate.Year
                                    && a.TransactionDate.Month <= toDate.Month
                                    && a.TransactionDate.Day <= toDate.Day
                                    && a.FirmId == FirmId
                                    && a.AccountId == AccountId
                                    orderby a.TransactionDate descending
                                    select new AccountTransactionResultModel
                                    {
                                        Id = a.Id,
                                        FirmName = a.Firm.Name,
                                        AccountName = a.Account.ContactName,
                                        Amount = a.Amount,
                                        TransactionsType = a.TransactionsType,
                                        PaymentType = a.PaymentType,
                                        TransactionDate = a.TransactionDate,
                                        Remarks = a.Remarks
                                    };
                    return todayData.ToList();
                }
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public List<AccountTransactionReportModel> GetTransactionReportData(int FirmId, int AccountId, DateTime toDate, DateTime fromDate)
        {
            try
            {
                using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
                {
                    var todayData = from a in db.AccountTransactions
                                    where a.TransactionDate.Year >= fromDate.Year
                                    && a.TransactionDate.Month >= fromDate.Month
                                    && a.TransactionDate.Day >= fromDate.Day
                                    && a.TransactionDate.Year <= toDate.Year
                                    && a.TransactionDate.Month <= toDate.Month
                                    && a.TransactionDate.Day <= toDate.Day
                                    && a.FirmId == FirmId
                                    && a.AccountId == AccountId
                                    orderby a.TransactionDate descending
                                    select new AccountTransactionReportModel
                                    {
                                        Id=a.Id,
                                        FirmName = a.Firm.Name,
                                        AccountName = a.Account.ContactName,
                                        Amount = a.Amount,
                                        TransactionsType = a.TransactionsType,
                                        PaymentType = a.PaymentType,
                                        TransactionDate = a.TransactionDate,
                                        Remarks = a.Remarks,
                                        //OpeningCredit=(a.Account.OpeningCredit != null) ? a.Account.OpeningCredit : 0,
                                        //OpeningDebit = (a.Account.OpeningDebit != null) ? a.Account.OpeningDebit : 0,
                                        //Balance =(a.TransactionsType == "Cr")? ((a.Account.OpeningCredit - a.Account.OpeningDebit) + a.Amount) : ((a.Account.OpeningCredit - a.Account.OpeningDebit) - a.Amount)
                                    };
                    return todayData.ToList();
                }
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public Data.Models.Account GetOpeningBalance(int FirmId, int AccountId)
        {
            try
            {
                using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
                {
                    return db.Accounts.FirstOrDefault(w => w.Id == AccountId && w.FirmId == FirmId);
                }
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public Data.Models.ChequeDetail GetChequeDetailsById(int TransactionId)
        {
            try
            {
                using(Data.Models.ProAccountContext db= new Data.Models.ProAccountContext())
                {
                    return db.ChequeDetails.FirstOrDefault(w => w.TransactionId == TransactionId);
                }
            }
            catch (SqlException)
            {
                return null;
            }
        }

    }
}
