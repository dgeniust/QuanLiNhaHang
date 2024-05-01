namespace QuanLiNhaHang.User_Control
{
    partial class UC_Food
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.btn_Plus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Minus = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(176, 3);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(415, 29);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Burger Bò xúc xích";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbl_Price.Location = new System.Drawing.Point(176, 43);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(144, 29);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "120.000đ";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Add
            // 
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(319, 98);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 40);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(167, 135);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbl_Ma.Location = new System.Drawing.Point(176, 98);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(144, 29);
            this.lbl_Ma.TabIndex = 1;
            this.lbl_Ma.Text = "120.000đ";
            this.lbl_Ma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Number
            // 
            this.lbl_Number.Location = new System.Drawing.Point(350, 72);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(37, 23);
            this.lbl_Number.TabIndex = 5;
            this.lbl_Number.Text = "0";
            this.lbl_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Plus
            // 
            this.btn_Plus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Plus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Plus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Plus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Plus.FillColor = System.Drawing.Color.Transparent;
            this.btn_Plus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Plus.ForeColor = System.Drawing.Color.White;
            this.btn_Plus.Image = global::QuanLiNhaHang.Properties.Resources.icons8_plus_24;
            this.btn_Plus.Location = new System.Drawing.Point(305, 65);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(30, 30);
            this.btn_Plus.TabIndex = 7;
            // 
            // btn_Minus
            // 
            this.btn_Minus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Minus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Minus.FillColor = System.Drawing.Color.Transparent;
            this.btn_Minus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Minus.ForeColor = System.Drawing.Color.White;
            this.btn_Minus.Image = global::QuanLiNhaHang.Properties.Resources.icons8_minus_24;
            this.btn_Minus.Location = new System.Drawing.Point(402, 65);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(30, 30);
            this.btn_Minus.TabIndex = 8;
            // 
            // UC_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Ma);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pictureBox);
            this.Name = "UC_Food";
            this.Size = new System.Drawing.Size(456, 141);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.Label lbl_Number;
        private Guna.UI2.WinForms.Guna2Button btn_Plus;
        private Guna.UI2.WinForms.Guna2Button btn_Minus;
    }
}
