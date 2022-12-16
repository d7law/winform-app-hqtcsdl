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
    public partial class frmDSDH : Form
    {
        public frmDSDH()
        {
            InitializeComponent();
        }

        private void btnTimKiemDH_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoaDH.Text;
            LoadDSDH();
        }
        private string tukhoa = "";
        private void LoadDSDH()
        {
            string sql = "sp_SelectAllDonHang";
            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvDSDH.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSDH_Load(object sender, EventArgs e)
        {
            LoadDSDH();
        }

        private void btnThemMoiDH_Click(object sender, EventArgs e)
        {
            new frmDH(null).ShowDialog();
            LoadDSDH();
        }

        private void dgvDSDH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mkh = dgvDSDH.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                new frmDH(mkh).ShowDialog();
                LoadDSDH();
            }
        }
    }
}
