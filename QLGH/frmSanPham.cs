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
    public partial class frmSanPham : Form
    {
        public frmSanPham(string msp)
        {
            this.msp = msp;
            InitializeComponent();
        }
        private string msp;
        private Database db;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            
            {
                new CustomParameter()
                {
                key = "@tukhoa",
                value = ""
                }  
            };
            //load dữ liệu cho combobox loại sản phẩm
            cbbLoaiSanPham.DataSource = db.SelectData("sp_SelectAllLoaiSP",lst);
            cbbLoaiSanPham.DisplayMember = "TenLoaiSP";// thuộc tính hiển thị combobox
            cbbLoaiSanPham.ValueMember = "MaLoaiSP";// giá trị hiển thiện combobox
            cbbLoaiSanPham.SelectedIndex = -1;

            if (string.IsNullOrEmpty(msp))
            {
                this.Text = "Thêm mới sản phẩm";
            }
            else
            {
                this.Text = "Cập nhật sản phẩm";
                var r = db.Select("sp_SelectSP '"+msp+"'");
                txtMaSP.Text = r["MaSP"].ToString();
                txtTenSP.Text = r["TenSP"].ToString();
                txtMoTa.Text = r["MoTa"].ToString();
                txtDonGia.Text = r["DonGia"].ToString();
                cbbLoaiSanPham.SelectedValue = r["MaLoaiSP"].ToString();
            }
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if(cbbLoaiSanPham.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm");
                return;
            }
            string sql = "";

            string MaSP = txtMaSP.Text;
            string TenSP = txtTenSP.Text;
            string MoTa = txtMoTa.Text;
            string DonGia = txtDonGia.Text;
            string MaLoaiSP = cbbLoaiSanPham.Text;
            

            List<CustomParameter> lstPara = new List<CustomParameter>();
            
            if (string.IsNullOrEmpty(msp))
            {
                sql = "sp_ThemSanPham";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaSP",
                    value = MaSP
                });
            }
            else
            {
                sql = "sp_UpdateSanPham";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaSP",
                    value = MaSP
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@TenSP",
                value = txtTenSP.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MoTa",
                value = txtMoTa.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DonGia",
                value = txtDonGia.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaLoaiSP",
                value = cbbLoaiSanPham.SelectedValue.ToString()
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if(rs == 1)
            {
                if (string.IsNullOrEmpty(msp))
                {
                    MessageBox.Show("Thêm mới sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }
    }
}
