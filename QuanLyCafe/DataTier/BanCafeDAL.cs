using QuanLyCafe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DataTier
{
    internal class BanCafeDAL
    {
        private DBQLCFMODEL bQLCFMODEL;
        public BanCafeDAL()
        {
            bQLCFMODEL= new DBQLCFMODEL();
        }
        public IEnumerable<BanCafe> GetBanCafe()
        {
            return bQLCFMODEL.BanCafes.ToList();
        }
    }
}
