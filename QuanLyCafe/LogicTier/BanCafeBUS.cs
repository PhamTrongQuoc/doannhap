using QuanLyCafe.DataTier;
using QuanLyCafe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.LogicTier
{
    internal class BanCafeBUS
    {
        private BanCafeDAL banCafeDAL;
        public BanCafeBUS()
        {
            banCafeDAL = new BanCafeDAL();
        }
        public IEnumerable<BanCafe> GetBans()
        {
            return banCafeDAL.GetBanCafe();
        }
    }
}
