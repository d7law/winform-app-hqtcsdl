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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham(string maloaisp)
        {
            this.maloaisp = maloaisp;
            InitializeComponent();
        }
        private string maloaisp;

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(maloaisp))
            {
                this.Text = "Thêm mới loại sản phẩm";
            }
            else
            {
                this.Text = "Cập nhật loại sản phẩm";
                var r = new Database().Select("sp_SelectLoaiSP '" + maloaisp + "'");
                txtMaLoaiSP.Text = r["MaLoaiSP"].ToString();
                txtTenLoaiSP.Text = r["TenLoaiSP"].ToString();
            }
        }

        private void btnLuuLSP_Click(object sender, EventArgs e)
        {
            string sql = "";

            string MaLoaiSP = txtMaLoaiSP.Text;
            string TenLoaiSP = txtTenLoaiSP.Text;


            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(maloaisp))
            {
                sql = "sp_ThemLoaiSP";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaLoaiSP",
                    value = MaLoaiSP
                });
            }
            else
            {
                sql = "sp_UpdateLoaiSP";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaLoaiSP",
                    value = MaLoaiSP
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@TenLoaiSP",
                value = TenLoaiSP
            });

            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(maloaisp))
                {
                    MessageBox.Show("Thêm mới loại sản phẩm thành công");
                } 
                else
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }

        private void btnHuyLSP_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
