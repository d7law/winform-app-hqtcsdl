namespace QLGH
{
    partial class frmDSLOAISP
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
            this.dgvDSLOAISP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemLSP = new System.Windows.Forms.TextBox();
            this.btnTimKiemLSP = new System.Windows.Forms.Button();
            this.btnThemMoiLSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLOAISP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLOAISP
            // 
            this.dgvDSLOAISP.AllowUserToAddRows = false;
            this.dgvDSLOAISP.AllowUserToDeleteRows = false;
            this.dgvDSLOAISP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSLOAISP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLOAISP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLOAISP.Location = new System.Drawing.Point(0, 98);
            this.dgvDSLOAISP.MultiSelect = false;
            this.dgvDSLOAISP.Name = "dgvDSLOAISP";
            this.dgvDSLOAISP.ReadOnly = true;
            this.dgvDSLOAISP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLOAISP.Size = new System.Drawing.Size(1051, 358);
            this.dgvDSLOAISP.TabIndex = 0;
            this.dgvDSLOAISP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLOAISP_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // txtTimKiemLSP
            // 
            this.txtTimKiemLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemLSP.Location = new System.Drawing.Point(619, 37);
            this.txtTimKiemLSP.Name = "txtTimKiemLSP";
            this.txtTimKiemLSP.Size = new System.Drawing.Size(174, 20);
            this.txtTimKiemLSP.TabIndex = 2;
            // 
            // btnTimKiemLSP
            // 
            this.btnTimKiemLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemLSP.Location = new System.Drawing.Point(799, 36);
            this.btnTimKiemLSP.Name = "btnTimKiemLSP";
            this.btnTimKiemLSP.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemLSP.TabIndex = 3;
            this.btnTimKiemLSP.Text = "Tìm kiếm";
            this.btnTimKiemLSP.UseVisualStyleBackColor = true;
            this.btnTimKiemLSP.Click += new System.EventHandler(this.btnTimKiemLSP_Click);
            // 
            // btnThemMoiLSP
            // 
            this.btnThemMoiLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiLSP.Location = new System.Drawing.Point(893, 36);
            this.btnThemMoiLSP.Name = "btnThemMoiLSP";
            this.btnThemMoiLSP.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoiLSP.TabIndex = 3;
            this.btnThemMoiLSP.Text = "Thêm mới";
            this.btnThemMoiLSP.UseVisualStyleBackColor = true;
            this.btnThemMoiLSP.Click += new System.EventHandler(this.btnThemMoiLSP_Click);
            // 
            // frmDSLOAISP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 456);
            this.Controls.Add(this.btnThemMoiLSP);
            this.Controls.Add(this.btnTimKiemLSP);
            this.Controls.Add(this.txtTimKiemLSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSLOAISP);
            this.Name = "frmDSLOAISP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách loại sản phẩm";
            this.Load += new System.EventHandler(this.frmDSLOAISP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLOAISP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLOAISP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemLSP;
        private System.Windows.Forms.Button btnTimKiemLSP;
        private System.Windows.Forms.Button btnThemMoiLSP;
    }
}