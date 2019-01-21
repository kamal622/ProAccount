using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProAccount.Core
{
    public static class Comman
    {
        public static string mProduct_Name = "";
        public static string Product_Name
        {
            get
            {
                if ((mProduct_Name.Length) == 0)
                    mProduct_Name = "Accouting System";
                return mProduct_Name;
            }

            set
            {
                mProduct_Name = value;
            }
        }
    }
}
