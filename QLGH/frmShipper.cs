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
    public partial class frmShipper : Form
    {
        public frmShipper(string mashipper)
        {
            this.mashipper = mashipper;
            InitializeComponent();
        }
        private string mashipper;

        private void frmShipper_Load(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(mashipper)) // nếu mã shipper ko có => thêm shipper mới
            {
                this.Text = "Thêm mới shipper";
            }
           else
            {
                this.Text = "Cập nhập thông tin shipper";
                // lấy thông tin chi tiết 1 shipper dựa vào mã shipper
                var r = new Database().Select("sp_XemChiTietShipper '"+mashipper+"'");
                //MessageBox.Show(r[0].ToString()); // kiểm tra có load thành công không
                //set giá trị vào form

                txtMaShipper.Text = r["MaShipper"].ToString();
                txtTenShipper.Text = r["TenShipper"].ToString();
                txtSDTShipper.Text = r["SDT"].ToString();
                if((r["GioiTinh"].ToString()) == "Male")
                {
                    rbtNam.Checked = true;
                }
                 else
                {
                    rbtNu.Checked = true;
                }
                txtDiaChiShipper.Text = r["DiaChi"].ToString();
                txtLuongShipper.Text = r["Luong"].ToString();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string MaShipper = txtMaShipper.Text;
            string TenShipper = txtTenShipper.Text;
            string SDT = txtSDTShipper.Text;
            string GioiTinh = rbtNam.Checked ? "Male" : "Female";
            string DiaChi = txtDiaChiShipper.Text;
            string Luong = txtLuongShipper.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mashipper))
            {
                sql = "sp_ThemShipper"; // thêm shipper
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaShipper",
                    value = MaShipper
                });
            }
            else // cập nhập shipper
            {
                sql = "sp_UpdateShipper";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaShipper",
                    value = MaShipper
                });
            }
         
            lstPara.Add(new CustomParameter()
            {
                key = "@TenShipper",
                value = TenShipper
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
                key = "@Luong",
                value = Luong
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if(rs == 1)
            {
                if (string.IsNullOrEmpty(mashipper))
                {
                    MessageBox.Show("Thêm mới shipper thành công");
                }else
                {
                    MessageBox.Show("Cập nhật shipper thành công");
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
