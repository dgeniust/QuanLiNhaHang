using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Class
{
    public class Employee
    {
        public string manv;
        public string tennv;
        public string sdt;
        public string tencv;
        public string macv;
        public DateTime CaLamViec;

        public Employee(string manv, string tennv, string sdt, string macv, DateTime caLamViec, string tencv)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.sdt = sdt;
            this.macv = macv;
            CaLamViec = caLamViec;
            this.tencv = tencv;
        }
        public Employee(DataRow dr)
        {
            this.manv = dr[0].ToString();
            this.tennv = dr[1].ToString();
            this.sdt = dr[2].ToString();
            this.tencv = dr[3].ToString();
            //this.CaLamViec = Convert.ToDateTime(dr[4].ToString());
        }
    }
}
