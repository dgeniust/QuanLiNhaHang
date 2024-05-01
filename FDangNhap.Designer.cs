namespace QuanLiNhaHang
{
    partial class FDangNhap
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
            this.uC_Register1 = new QuanLiNhaHang.User_Control.UC_Register();
            this.uC_Login1 = new QuanLiNhaHang.User_Control.UC_Login();
            this.SuspendLayout();
            // 
            // uC_Register1
            // 
            this.uC_Register1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Register1.Location = new System.Drawing.Point(0, 0);
            this.uC_Register1.Name = "uC_Register1";
            this.uC_Register1.Size = new System.Drawing.Size(708, 620);
            this.uC_Register1.TabIndex = 1;
            // 
            // uC_Login1
            // 
            this.uC_Login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Login1.Location = new System.Drawing.Point(0, 0);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(708, 620);
            this.uC_Login1.TabIndex = 0;
            this.uC_Login1.Visible = false;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 620);
            this.Controls.Add(this.uC_Register1);
            this.Controls.Add(this.uC_Login1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Control.UC_Login uC_Login1;
        private User_Control.UC_Register uC_Register1;
    }
}