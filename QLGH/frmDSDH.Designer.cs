namespace QLGH
{
    partial class frmDSDH
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
            this.txtTuKhoaDH = new System.Windows.Forms.TextBox();
            this.btnTimKiemDH = new System.Windows.Forms.Button();
            this.btnThemMoiDH = new System.Windows.Forms.Button();
            this.dgvDSDH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            // 
            // txtTuKhoaDH
            // 
            this.txtTuKhoaDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoaDH.Location = new System.Drawing.Point(484, 35);
            this.txtTuKhoaDH.Name = "txtTuKhoaDH";
            this.txtTuKhoaDH.Size = new System.Drawing.Size(178, 20);
            this.txtTuKhoaDH.TabIndex = 1;
            // 
            // btnTimKiemDH
            // 
            this.btnTimKiemDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemDH.Location = new System.Drawing.Point(682, 34);
            this.btnTimKiemDH.Name = "btnTimKiemDH";
            this.btnTimKiemDH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemDH.TabIndex = 2;
            this.btnTimKiemDH.Text = "Tìm kiếm";
            this.btnTimKiemDH.UseVisualStyleBackColor = true;
            this.btnTimKiemDH.Click += new System.EventHandler(this.btnTimKiemDH_Click);
            // 
            // btnThemMoiDH
            // 
            this.btnThemMoiDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiDH.Location = new System.Drawing.Point(780, 34);
            this.btnThemMoiDH.Name = "btnThemMoiDH";
            this.btnThemMoiDH.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoiDH.TabIndex = 2;
            this.btnThemMoiDH.Text = "Thêm mới";
            this.btnThemMoiDH.UseVisualStyleBackColor = true;
            this.btnThemMoiDH.Click += new System.EventHandler(this.btnThemMoiDH_Click);
            // 
            // dgvDSDH
            // 
            this.dgvDSDH.AllowUserToAddRows = false;
            this.dgvDSDH.AllowUserToDeleteRows = false;
            this.dgvDSDH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDH.Location = new System.Drawing.Point(0, 100);
            this.dgvDSDH.MultiSelect = false;
            this.dgvDSDH.Name = "dgvDSDH";
            this.dgvDSDH.ReadOnly = true;
            this.dgvDSDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDH.Size = new System.Drawing.Size(869, 358);
            this.dgvDSDH.TabIndex = 3;
            this.dgvDSDH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDH_CellDoubleClick);
            // 
            // frmDSDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 458);
            this.Controls.Add(this.dgvDSDH);
            this.Controls.Add(this.btnThemMoiDH);
            this.Controls.Add(this.btnTimKiemDH);
            this.Controls.Add(this.txtTuKhoaDH);
            this.Controls.Add(this.label1);
            this.Name = "frmDSDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đơn hàng";
            this.Load += new System.EventHandler(this.frmDSDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuKhoaDH;
        private System.Windows.Forms.Button btnTimKiemDH;
        private System.Windows.Forms.Button btnThemMoiDH;
        private System.Windows.Forms.DataGridView dgvDSDH;
    }
}