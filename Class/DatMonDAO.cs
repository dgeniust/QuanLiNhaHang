using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.Class
{
    public class DatMonDAO
    {
        DBConnection db = new DBConnection();
        public void AddTable(DatMon dm)
        {
            string query = string.Format("INSERT INTO DatMon (MaDH, MaTK, MaMon, Slmon, GhiChu, MaBan) VALUES('{0}', '{1}', '{2}', {3}, '{4}','{5}')", dm.madh, dm.matk, dm.mamon,dm.slg,dm.ghichu, dm.maban);
            db.ThucThi(query);
        }
    }
}
