using QuanLyCafe.DataTier;
using QuanLyCafe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.LogicTier
{
    internal class MonBus
    {
        private MonDAL mon;
        public MonBus()
        {
            mon = new MonDAL();
        }
        public IEnumerable<Mon> GetMons(int maDanhMuc)
        { 
       
          return mon.GetMons(maDanhMuc);
        }
    }
}
