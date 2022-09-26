using QuanLyCafe.DataTier;
using QuanLyCafe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.LogicTier
{
    internal class DanhMucBUS
    {
        private DanhMucDAL MucDAL ;
        public DanhMucBUS()
        {
            MucDAL = new DanhMucDAL();
        }
        public IEnumerable<DanhMuc> GetMucDALs()
        {
            return MucDAL.GetDanhMucs();

        }
    }
}
