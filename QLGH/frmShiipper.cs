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
    public partial class frmShiipper : Form
    {
        public frmShiipper()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string tukhoa = "";

        private void frmShiipper_Load(object sender, EventArgs e)
        {
            LoadDSShipper();
        }

        private void LoadDSShipper()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            // load toàn bộ danh sách shipper khi form được load
            dgvShipper.DataSource = new Database().SelectData("sp_TimKiemTheoTuKhoa", lstPara);
            // đặt tên cột
            dgvShipper.Columns["MaShipper"].HeaderText = "Mã Shipper";
            dgvShipper.Columns["TenShipper"].HeaderText = "Tên Shipper";
            dgvShipper.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvShipper.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvShipper.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvShipper.Columns["Luong"].HeaderText = "Lương Shipper";
        }

        private void dgvShipper_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                var mashipper = dgvShipper.Rows[e.RowIndex].Cells["MaShipper"].Value.ToString();
                // truyền mã shipper vào form shipper
                new frmShipper(mashipper).ShowDialog();

                LoadDSShipper();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // frmShipper là frm thông tin shiiper
            new frmShipper(null).ShowDialog(); // nếu thêm mới shipper => mã shipper = null
            LoadDSShipper();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSShipper();
        }
    }
}
