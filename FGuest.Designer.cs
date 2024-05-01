namespace QuanLiNhaHang
{
    partial class FGuest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Guest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guest)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1056, 128);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(133, 36);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(50, 128);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(948, 36);
            this.txt_Search.TabIndex = 9;
            // 
            // dgv_Guest
            // 
            this.dgv_Guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Guest.Location = new System.Drawing.Point(50, 191);
            this.dgv_Guest.Name = "dgv_Guest";
            this.dgv_Guest.RowHeadersWidth = 51;
            this.dgv_Guest.RowTemplate.Height = 24;
            this.dgv_Guest.Size = new System.Drawing.Size(1139, 444);
            this.dgv_Guest.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hỗ trợ khách hàng";
            // 
            // FGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 680);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_Guest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGuest";
            this.Load += new System.EventHandler(this.FGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.DataGridView dgv_Guest;
        private System.Windows.Forms.Label label1;
    }
}