using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProAccount.Data;

namespace ProAccount.Service.Firm
{
    public class FirmService
    {
        public Data.Models.Firm[] GetAllFirm()
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.Firms.ToArray();
            }
        }

        public void SaveFirm(int Id, string Name)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                if (Id > 0)
                {
                    var result = db.Firms.FirstOrDefault(w => w.Id == Id);
                    if (result != null)
                    {
                        result.Name = Name;
                        db.SaveChanges();
                    }
                }
                else
                {
                    db.Firms.Add(new Data.Models.Firm { Name = Name });
                    db.SaveChanges();
                }
            }
        }

        public Data.Models.Firm[] GetFirmList()
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.Firms.OrderBy(o=>o.Name).ToArray();
            }
        }

        public Data.Models.Firm GetFirmById(int Id)
        {
            using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
            {
                return db.Firms.FirstOrDefault(w => w.Id == Id);
            }
        }

        public void DeleteFirmById(int Id)
        {
            using(Data.Models.ProAccountContext db=new Data.Models.ProAccountContext())
            {
                var data = db.Firms.FirstOrDefault(w => w.Id == Id);
                if (data != null)
                {
                    db.Firms.Remove(data);
                    db.SaveChanges();
                }
            }
        }

        public bool FirmIsExists(string Name)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                var data = db.Firms.FirstOrDefault(w => w.Name == Name);
                if (data != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }


        public Data.Models.Firm GetFirmByName(string Name)
        {
            using (Data.Models.ProAccountContext db = new Data.Models.ProAccountContext())
            {
                return db.Firms.FirstOrDefault(w => w.Name == Name);
            }
        }

    }
}
