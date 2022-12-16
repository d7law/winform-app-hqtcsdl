using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGH
{
    public partial class frmDSLOAISP : Form
    {
        public frmDSLOAISP()
        {
            InitializeComponent();
        }

        private void btnThemMoiLSP_Click(object sender, EventArgs e)
        {
            new frmLoaiSanPham(null).ShowDialog();
            LoadDSLOAISP();
        }

        private void LoadDSLOAISP()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa" , 
                value = tukhoa
            });
            dgvDSLOAISP.DataSource = new Database().SelectData("sp_SelectAllLoaiSP", lstPara);
        }

        private void dgvDSLOAISP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var maloaisp = dgvDSLOAISP.Rows[e.RowIndex].Cells["MaLoaiSP"].Value.ToString();
                new frmLoaiSanPham(maloaisp).ShowDialog();
                LoadDSLOAISP();
            }
        }
        private string tukhoa = "";

        private void frmDSLOAISP_Load(object sender, EventArgs e)
        {
            LoadDSLOAISP();
            dgvDSLOAISP.Columns["MaLoaiSP"].HeaderText = "Mã loại sản phẩm";
            dgvDSLOAISP.Columns["TenLoaiSP"].HeaderText = "Tên loại sản phẩm";
        }

        private void btnTimKiemLSP_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiemLSP.Text;
            LoadDSLOAISP();
        }
    }
}
