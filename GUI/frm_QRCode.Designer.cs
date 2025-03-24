namespace GUI
{
    partial class frm_QRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QRCode));
            this.pictureBox_QR = new System.Windows.Forms.PictureBox();
            this.pnl_ThanhToan = new System.Windows.Forms.Panel();
            this.lb_SoTien = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).BeginInit();
            this.pnl_ThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_QR
            // 
            this.pictureBox_QR.Location = new System.Drawing.Point(83, 89);
            this.pictureBox_QR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_QR.Name = "pictureBox_QR";
            this.pictureBox_QR.Size = new System.Drawing.Size(253, 270);
            this.pictureBox_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_QR.TabIndex = 1;
            this.pictureBox_QR.TabStop = false;
            // 
            // pnl_ThanhToan
            // 
            this.pnl_ThanhToan.Controls.Add(this.lb_SoTien);
            this.pnl_ThanhToan.Controls.Add(this.lb1);
            this.pnl_ThanhToan.Controls.Add(this.pictureBox_QR);
            this.pnl_ThanhToan.Controls.Add(this.pictureBox1);
            this.pnl_ThanhToan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ThanhToan.Location = new System.Drawing.Point(0, 0);
            this.pnl_ThanhToan.Name = "pnl_ThanhToan";
            this.pnl_ThanhToan.Size = new System.Drawing.Size(420, 576);
            this.pnl_ThanhToan.TabIndex = 4;
            // 
            // lb_SoTien
            // 
            this.lb_SoTien.AutoSize = true;
            this.lb_SoTien.BackColor = System.Drawing.Color.White;
            this.lb_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.lb_SoTien.Location = new System.Drawing.Point(224, 506);
            this.lb_SoTien.Name = "lb_SoTien";
            this.lb_SoTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_SoTien.Size = new System.Drawing.Size(79, 16);
            this.lb_SoTien.TabIndex = 3;
            this.lb_SoTien.Text = "Thành tiền";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.White;
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.lb1.Location = new System.Drawing.Point(93, 506);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(69, 16);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Thành tiền";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 576);
            this.Controls.Add(this.pnl_ThanhToan);
            this.Name = "frm_QRCode";
            this.Text = "frm_QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).EndInit();
            this.pnl_ThanhToan.ResumeLayout(false);
            this.pnl_ThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_QR;
        private System.Windows.Forms.Panel pnl_ThanhToan;
        private System.Windows.Forms.Label lb_SoTien;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}