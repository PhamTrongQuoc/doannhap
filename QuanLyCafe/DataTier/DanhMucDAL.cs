using QuanLyCafe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DataTier
{
    internal class DanhMucDAL 
    {
        private DBQLCFMODEL dBQLCFMODEL;
        public DanhMucDAL()
        {
            dBQLCFMODEL = new DBQLCFMODEL();
        }
        public IEnumerable<DanhMuc> GetDanhMucs()
        {
            return dBQLCFMODEL.DanhMucs.ToList();
        }
    }
}
