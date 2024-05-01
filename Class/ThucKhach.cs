using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Class
{
    public class ThucKhach
    {
        public string matk;
        public string tentk;
        public string sdt;

        public ThucKhach(string matk, string tentk, string sdt)
        {
            this.matk = matk;
            this.tentk = tentk;
            this.sdt = sdt;
        }
        public ThucKhach(DataRow dr)
        {
            this.matk = dr[0].ToString();
            this.tentk = dr[1].ToString();
            this.sdt = dr[2].ToString();
        }
    }
}
