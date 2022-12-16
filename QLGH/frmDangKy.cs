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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //@TenKH varchar(50), @Email varchar(30), @SDT varchar(30),
            //@GioiTinh varchar(10), @DiaChi varchar(50), 
            //	@TenDangNhap varchar(20), @MatKhau varchar(20)

            Boolean rs = new Database()
                .DangKy(txtTenKH.Text, txtEmail.Text, txtSDT.Text, txtGioiTinh.Text, txtDiaChi.Text, txtTenDangNhap.Text, txtMatKhau.Text);
            if (rs == true)
            {
                DialogResult dr  = MessageBox.Show("Đăng ký thành công", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Vui lòng thử lại", "Failed");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
