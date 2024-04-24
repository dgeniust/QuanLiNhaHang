namespace QuanLiNhaHang.User_Control
{
    partial class UC_Employee
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Job = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLiNhaHang.Properties.Resources.ava;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(15, 186);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(205, 33);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Nguyễn Văn A";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Job
            // 
            this.lbl_Job.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job.Location = new System.Drawing.Point(16, 230);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(100, 23);
            this.lbl_Job.TabIndex = 3;
            this.lbl_Job.Text = "Nhân viên";
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Job);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(223, 287);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Job;
    }
}
