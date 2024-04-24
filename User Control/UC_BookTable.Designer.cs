namespace QuanLiNhaHang.User_Control
{
    partial class UC_BookTable
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_MaBan = new System.Windows.Forms.Label();
            this.lbl_MaTK = new System.Windows.Forms.Label();
            this.lbl_slg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::QuanLiNhaHang.Properties.Resources.icons8_table_64;
            this.pictureBox.Location = new System.Drawing.Point(37, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(88, 69);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lbl_MaBan
            // 
            this.lbl_MaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaBan.Location = new System.Drawing.Point(3, 8);
            this.lbl_MaBan.Name = "lbl_MaBan";
            this.lbl_MaBan.Size = new System.Drawing.Size(122, 23);
            this.lbl_MaBan.TabIndex = 1;
            this.lbl_MaBan.Text = "Mã bàn: ";
            // 
            // lbl_MaTK
            // 
            this.lbl_MaTK.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTK.Location = new System.Drawing.Point(3, 106);
            this.lbl_MaTK.Name = "lbl_MaTK";
            this.lbl_MaTK.Size = new System.Drawing.Size(154, 23);
            this.lbl_MaTK.TabIndex = 2;
            this.lbl_MaTK.Text = "Mã thực khách: ";
            // 
            // lbl_slg
            // 
            this.lbl_slg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slg.Location = new System.Drawing.Point(4, 129);
            this.lbl_slg.Name = "lbl_slg";
            this.lbl_slg.Size = new System.Drawing.Size(153, 23);
            this.lbl_slg.TabIndex = 2;
            this.lbl_slg.Text = "Số lượng: ";
            // 
            // UC_BookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_slg);
            this.Controls.Add(this.lbl_MaTK);
            this.Controls.Add(this.lbl_MaBan);
            this.Controls.Add(this.pictureBox);
            this.Name = "UC_BookTable";
            this.Size = new System.Drawing.Size(160, 164);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbl_MaBan;
        private System.Windows.Forms.Label lbl_MaTK;
        private System.Windows.Forms.Label lbl_slg;
    }
}
