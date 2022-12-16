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
    public partial class frmDSSP : Form
    {
        public frmDSSP()
        {
            InitializeComponent();
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoaSP.Text;
            loadDSSP();
        }

        private string tukhoa = "";

        private void loadDSSP()
        {
            string sql = "sp_SelectAllSPNANGCAO";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSSP.DataSource = new Database().SelectData(sql , lstPara);
        }

        private void frmDSSP_Load(object sender, EventArgs e)
        {
            loadDSSP();
        }

        private void btnThemMoiSP_Click(object sender, EventArgs e)
        {
            new frmSanPham(null).ShowDialog();
            loadDSSP();
        }

        private void dgvDSSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var msp = dgvDSSP.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                new frmSanPham(msp).ShowDialog();
                loadDSSP();
            }
        }
    }
}
