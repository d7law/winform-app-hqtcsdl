namespace QLGH
{
    partial class frmLoaiSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.btnLuuLSP = new System.Windows.Forms.Button();
            this.btnHuyLSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(200, 36);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(208, 20);
            this.txtMaLoaiSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(200, 84);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(208, 20);
            this.txtTenLoaiSP.TabIndex = 1;
            // 
            // btnLuuLSP
            // 
            this.btnLuuLSP.Location = new System.Drawing.Point(200, 153);
            this.btnLuuLSP.Name = "btnLuuLSP";
            this.btnLuuLSP.Size = new System.Drawing.Size(75, 23);
            this.btnLuuLSP.TabIndex = 2;
            this.btnLuuLSP.Text = "Lưu";
            this.btnLuuLSP.UseVisualStyleBackColor = true;
            this.btnLuuLSP.Click += new System.EventHandler(this.btnLuuLSP_Click);
            // 
            // btnHuyLSP
            // 
            this.btnHuyLSP.Location = new System.Drawing.Point(333, 153);
            this.btnHuyLSP.Name = "btnHuyLSP";
            this.btnHuyLSP.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLSP.TabIndex = 2;
            this.btnHuyLSP.Text = "Hủy";
            this.btnHuyLSP.UseVisualStyleBackColor = true;
            this.btnHuyLSP.Click += new System.EventHandler(this.btnHuyLSP_Click);
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 268);
            this.Controls.Add(this.btnHuyLSP);
            this.Controls.Add(this.btnLuuLSP);
            this.Controls.Add(this.txtTenLoaiSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLoaiSP);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiSanPham";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.Button btnLuuLSP;
        private System.Windows.Forms.Button btnHuyLSP;
    }
}