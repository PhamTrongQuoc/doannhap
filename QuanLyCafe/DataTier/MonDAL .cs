using QuanLyCafe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DataTier
{
    internal class MonDAL
    {
         private DBQLCFMODEL dBQLCFMODEL;
        public MonDAL()
        {
            dBQLCFMODEL = new DBQLCFMODEL();
        }
        public IEnumerable<Mon> GetMons(int maDanhMuc)
        {
            return dBQLCFMODEL.Mons.Where(x=>x.MaDanhMuc == maDanhMuc).ToList();
        }
    }
}
