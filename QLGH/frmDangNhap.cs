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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        public string tendangnhap = "";
        public string loaitk = "";
        // public string matkhau = "";

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc
            // ktra ràng buộc
            if (cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Tài khoản không được trống");
                txtTenDangNhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu","Mật khẩu không được trống");
                // txtMatKhau.Select();
                //return;
            }
            #endregion

            tendangnhap = txtTenDangNhap.Text;
            loaitk = "";

            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Admin":
                    loaitk = "Admin";
                    break;
                case "User":
                    loaitk="User";
                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value=loaitk
                },
                 new CustomParameter()
                {
                    key = "@TenDangNhap",
                    value=txtTenDangNhap.Text
                },
                  new CustomParameter()
                {
                    key = "@MatKhau",
                    value =txtMatKhau.Text
                },
            };
            RoleState.role = loaitk;
            var rs = new Database().SelectData("sp_DangNhap", lst);
            if(rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản hoặc mật khẩu","Tài khoản hoặc mật khẩu không đúng");
            }
            
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            frmDangKy f = new frmDangKy();
            f.Show();
        }
    }
}
