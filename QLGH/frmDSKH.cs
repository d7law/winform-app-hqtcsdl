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
    public partial class frmDSKH : Form
    {
        public frmDSKH()
        {
            InitializeComponent();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoaKH.Text;
            LoadDSKH();
        }
        private string tukhoa = "";
        private void LoadDSKH()
        {
            string sql = "sp_SelectAllKH";
            List<CustomParameter> lstPara = new List<CustomParameter>();
          
                lstPara.Add(new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                });
            
            dgbDSKH.DataSource = new Database().SelectData(sql,lstPara);
        }

        private void frmDSKH_Load(object sender, EventArgs e)
        {
            LoadDSKH();
        }

        private void btnThemMoiKH_Click(object sender, EventArgs e)
        {
            new frmKH(null).ShowDialog();
            LoadDSKH();
        }

        private void dgbDSKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mkh = dgbDSKH.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                new frmKH(mkh).ShowDialog();
                LoadDSKH();
            }
          
        }
    }
}
