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
        public FBookTable()
        {
            InitializeComponent();
            LoadForm();
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
            BookTable bt = new BookTable("", txt_MaTK.Text, Convert.ToInt32(txt_Slg.Text), txt_MaBan.Text, dateTimePicker.Value.Date);
            btDAO.AddTable(bt);
            string settable = "UPDATE BAN SET TrangThai ='UNAVAILABLE' WHERE MABAN ='"+txt_MaBan.Text +"'";
            db.ThucThi(settable);
            FFood food = new FFood(bt);
            food.Show();
            this.Hide();
        }

        private void btn_ChangeTable_Click(object sender, EventArgs e)
        {
            string query = string.Format("Update DatBan Set maban = '{0}' where maban = '{1}'", txt_ChangeTable.Text, txt_MaBan.Text);
            db.ThucThi(query);
            LoadForm();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {

        }
    }
}
