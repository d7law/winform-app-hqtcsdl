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
    public partial class frmKH : Form
    {
        public frmKH(string mkh)
        {
            this.mkh = mkh;
            InitializeComponent();
        }
        private string mkh;

        private void frmKH_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mkh))
            {
                this.Text = "Thêm mới khách hàng";
            }
            else
            {
                this.Text = "Cập nhật khách hàng";
                var r = new Database().Select("sp_SelectKH '" + mkh + "'");

                txtMaKH.Text = r["MaKH"].ToString();
                txtTenKH.Text = r["TenKH"].ToString();
                txtEmailKH.Text = r["Email"].ToString();
                txtSDT.Text = r["SDT"].ToString();
                if ((r["GioiTinh"].ToString()) == "Male")
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtDiaChi.Text = r["DiaChi"].ToString();
                txtMaTK.Text = r["MaTK"].ToString();
            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            string sql = "";

            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string Email = txtEmailKH.Text;
            string SDT = txtSDT.Text;
            string GioiTinh = rbtNam.Checked ? "Male" : "Female";
            string DiaChi = txtDiaChi.Text;
            string MaTK = txtMaTK.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mkh))
            {
                sql = "sp_ThemKhachHang";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaKH",
                    value = MaKH
                });
            } 
            else
            {
                sql = "sp_UpdateKhachHang";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaKH",
                    value = MaKH
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@TenKH",
                value = TenKH
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = SDT
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = GioiTinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = DiaChi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaTK",
                value = MaTK
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mkh))
                {
                    MessageBox.Show("Thêm mới khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}
