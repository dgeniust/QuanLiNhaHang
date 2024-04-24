using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Class
{
    public class Food
    {
        public string mamon;
        public string tenmon;
        public double gia;
        public string mota;
        public string image;

        public Food(string mamon, string tenmon, float gia, string mota, string image)
        {
            this.mamon = mamon;
            this.tenmon = tenmon;
            this.gia = gia;
            this.mota = mota;
            this.image = image;
        }
        public Food(DataRow dr)
        {
            this.mamon = dr[0].ToString();
            this.tenmon = dr[1].ToString();
            this.gia = Convert.ToDouble(dr[2].ToString());
            this.mota = dr[3].ToString();
            this.image = dr[4].ToString();
        }
    }
}
