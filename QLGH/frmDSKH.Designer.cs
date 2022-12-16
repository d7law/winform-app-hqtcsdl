namespace QLGH
{
    partial class frmDSKH
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
            this.txtTuKhoaKH = new System.Windows.Forms.TextBox();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.btnThemMoiKH = new System.Windows.Forms.Button();
            this.dgbDSKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            // 
            // txtTuKhoaKH
            // 
            this.txtTuKhoaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoaKH.Location = new System.Drawing.Point(486, 30);
            this.txtTuKhoaKH.Name = "txtTuKhoaKH";
            this.txtTuKhoaKH.Size = new System.Drawing.Size(203, 20);
            this.txtTuKhoaKH.TabIndex = 1;
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemKH.Location = new System.Drawing.Point(721, 29);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemKH.TabIndex = 2;
            this.btnTimKiemKH.Text = "Tìm kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // btnThemMoiKH
            // 
            this.btnThemMoiKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiKH.Location = new System.Drawing.Point(812, 29);
            this.btnThemMoiKH.Name = "btnThemMoiKH";
            this.btnThemMoiKH.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoiKH.TabIndex = 2;
            this.btnThemMoiKH.Text = "Thêm mới";
            this.btnThemMoiKH.UseVisualStyleBackColor = true;
            this.btnThemMoiKH.Click += new System.EventHandler(this.btnThemMoiKH_Click);
            // 
            // dgbDSKH
            // 
            this.dgbDSKH.AllowUserToAddRows = false;
            this.dgbDSKH.AllowUserToDeleteRows = false;
            this.dgbDSKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDSKH.Location = new System.Drawing.Point(0, 87);
            this.dgbDSKH.MultiSelect = false;
            this.dgbDSKH.Name = "dgbDSKH";
            this.dgbDSKH.ReadOnly = true;
            this.dgbDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbDSKH.Size = new System.Drawing.Size(926, 376);
            this.dgbDSKH.TabIndex = 3;
            this.dgbDSKH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbDSKH_CellDoubleClick);
            // 
            // frmDSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 463);
            this.Controls.Add(this.dgbDSKH);
            this.Controls.Add(this.btnThemMoiKH);
            this.Controls.Add(this.btnTimKiemKH);
            this.Controls.Add(this.txtTuKhoaKH);
            this.Controls.Add(this.label1);
            this.Name = "frmDSKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.frmDSKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbDSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuKhoaKH;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Button btnThemMoiKH;
        private System.Windows.Forms.DataGridView dgbDSKH;
    }
}