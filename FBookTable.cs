using Guna.UI2.WinForms;
using QuanLiNhaHang.Class;
using QuanLiNhaHang.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class FBookTable : Form
    {
        DBConnection db = new DBConnection();
        BookTableDAO btDAO = new BookTableDAO();
        public Guna2TextBox TXT_MABAN => txt_MaBan;
        public Guna2Button BTN_HOME => btn_Home;
        public Guna2Button BTN_DATHANG => btn_DatHang;
        public Guna2Button BTN_DATMON => btn_DatMon;
        public Guna2Button BTN_DATBAN => btn_DatBan;
        public Guna2Button BTN_THUCKHACH => btn_ThucKhach;
        public Guna2Button BTN_NV => btn_NV;
        string ma = "";
        string type = "";
        public FBookTable()
        {
            InitializeComponent();
            LoadForm();
        }
        public FBookTable(string MA, string TYPE)
        {
            InitializeComponent();
            LoadForm();
            this.ma = MA;
            this.type = TYPE;
            this.txt_MaTK.Text = MA;
            if(type == "Thuckhach")
            {
                btn_Home.Enabled = false;
                btn_NV.Enabled = false;
            }
            else
            {

                btn_Home.Enabled = true;
                btn_NV.Enabled = true;
            }
        }
        public void LoadForm()
        {
            string query = "Select * from ban";
            GeneratePanel(query, Panel_BookTable);
            this.Refresh(); 
        }
        public void GeneratePanel(string query, Panel storage_panel)
        {
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(120, 125),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Table tb = new Table(dr);
                //BookTable bt = new BookTable(dr);
                UC_BookTable uC_BookTable= new UC_BookTable(tb,this);
                panel.Controls.Add(uC_BookTable);
                storage_panel.Controls.Add(panel);
            }
        }

        private void btn_BookTable_Click(object sender, EventArgs e)
        {
            BookTable bt = new BookTable("", ma, Convert.ToInt32(txt_Slg.Text), txt_MaBan.Text, dateTimePicker.Value.Date);
            btDAO.AddTable(bt);
            string settable = "UPDATE BAN SET TrangThai ='UNAVAILABLE' WHERE MABAN ='"+txt_MaBan.Text +"'";
            db.ThucThi(settable);
            FFood food = new FFood(bt,type);
            food.Show();
            this.Hide();
        }

        private void btn_ChangeTable_Click(object sender, EventArgs e)
        {
            string query = string.Format("Update DatBan Set maban = '{0}' where maban = '{1}'", txt_ChangeTable.Text, ma);
            db.ThucThi(query);
            LoadForm();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {

        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            FBookTable fb = new FBookTable();
            fb.Show();
            this.Hide();
            fb.BTN_DATBAN.BackColor = Color.White;
            fb.BTN_DATBAN.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_DatMon_Click(object sender, EventArgs e)
        {
            FFood ff = new FFood();
            ff.Show();
            this.Hide();
            ff.BTN_DATMON.BackColor = Color.White;
            ff.BTN_DATMON.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            FEmployee fe = new FEmployee();
            fe.Show();
            this.Hide();
            fe.BTN_NV.BackColor = Color.White;
            fe.BTN_NV.ForeColor = Color.FromArgb(30, 40, 45);
        }
    }
}
