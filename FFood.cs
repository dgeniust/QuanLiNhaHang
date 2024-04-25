﻿using QuanLiNhaHang.Class;
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
    public partial class FFood : Form
    {
        DBConnection db = new DBConnection();
        BookTable bt;
        Food food;
        UC_Food uc_f;
        public int slg;
        public string mamon;
        public string madhtemp = "";
        DatMonDAO dmD = new DatMonDAO();
        public FFood()
        {
            InitializeComponent();
        }
        public FFood(BookTable BT)
        {
            InitializeComponent();
            this.bt = BT;
        }
        bool sidebar_timer;
        public Label LBL_NUMBEROGFOOD => lbl_NumberOfFood;
        

        private void FFood_Load(object sender, EventArgs e)
        {
            string query = "Select * from monan";
            GeneratePanel(query, Panel_Food);
            string query1 = "select MAX(madh) from donhang";
            DataTable dt = db.LoadData(query1);
            foreach(DataRow dr in dt.Rows)
            {
               bt.madh = dr[0].ToString();
            }
            madhtemp = bt.madh;
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
                    Size = new Size(330, 115),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Food FOOD = new Food(dr);
                this.food = FOOD;
                UC_Food uC_Food = new UC_Food(FOOD, this);
                this.uc_f = uC_Food;
                uC_Food.BTN_ADDFOOD.Click += AddFood;
                panel.Controls.Add(uC_Food);
                storage_panel.Controls.Add(panel);
            }
        }
        public string tempdh = "";
        public void AddFood(object sender, EventArgs e)
        {
            DatMon dm = new DatMon(bt.madh, bt.matk, mamon, Convert.ToInt32(uc_f.LBL_NUMBER.Text), "NOTE", bt.maban);
            dmD.AddTable(dm);
            tempdh = dm.madh;
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_ShowFood_Click(object sender, EventArgs e)
        {
            FBill fb = new FBill(bt, tempdh);
            fb.ShowDialog();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebar_timer)
            {
                SideBar_FlowPanel.Width -= 30;
                if (SideBar_FlowPanel.Width == SideBar_FlowPanel.MinimumSize.Width)
                {
                    sidebar_timer = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                SideBar_FlowPanel.Width += 30;
                if (SideBar_FlowPanel.Width == SideBar_FlowPanel.MaximumSize.Width)
                {
                    sidebar_timer = true;
                    sidebarTimer.Stop();
                }
            }
        }
    }
}