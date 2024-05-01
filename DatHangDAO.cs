using QuanLiNhaHang.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang
{
    public class DatHangDAO
    {
        DBConnection db = new DBConnection();
        public void BookShip(DatHang dm)
        {
            string query = string.Format("exec Themdatmon '{0}', '{1}', '{2}', {3}, N'{4}',N'{5}'", dm.madh, dm.matk, dm.mamon, dm.slg, dm.ghichu, dm.diachi);
            
            db.ThucThi(query);
        }
    }
}
