using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProAccount.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Reflection;
using ProAccount.Service.Model;

namespace ProAccount.Service.Comman
{
    public class CommanService
    {
        public Array GetData(string Qry,string tblName)
        {
            try
            {
                using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
                {
                    if (tblName == "Firm")
                    {
                        return db.Database.SqlQuery<FirmResultModel>(Qry).ToArray();
                    }
                    else if (tblName == "Account")
                    {
                        return db.Database.SqlQuery<AccountResultModel>(Qry).ToArray();
                    }
                    else if (tblName == "AccountType")
                    {
                        return db.Database.SqlQuery<AccountTypeResultModel>(Qry).ToArray();
                    }
                    else
                        return null;
                }
            }
            catch (SqlException ex)
            {
                //MsgBox(ex.Message);
                return null;
            }
        }

        public Data.Models.User GetUserName(string UserName)
        {
            try
            {
                using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
                {
                   return db.Users.FirstOrDefault(w => w.UserName == UserName);
                }
            }
            catch(SqlException ex)
            {
                return null;
            }
        }
    }
}
