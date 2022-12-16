using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGH
{
    public partial class frmDH : Form
    {
        public frmDH(string mdh)
        {
            this.mdh = mdh;
            InitializeComponent();
        }
        private string mdh;

        private void frmDH_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mdh))
            {
                this.Text = "Thêm đơn hàng mới";
            }
            else
            {
                this.Text = "Cập nhật đơn hàng";
                var r = new Database().Select("sp_SelectDonHang '" + mdh + "'");

                txtMaDH.Text = r["MaDH"].ToString();
                txtTrangThai.Text = r["TrangThai"].ToString();
                txtDiaChiGiao.Text = r["DiaChiGiao"].ToString();
                txtSDT.Text = r["SDT"].ToString();
                txtNgayDat.Text = r["NgayDat"].ToString();
                txtNgayGiao.Text = r["NgayGiao"].ToString();
                txtMoTa.Text = r["MoTa"].ToString();
                txtCuocPhi.Text = r["CuocPhi"].ToString();
                txtTongTien.Text = r["TongTien"].ToString();
                txtMaKH.Text = r["MaKH"].ToString();
                txtMaShipper.Text = r["MaShipper"].ToString();
            }
        }

        private void btnLuuDH_Click(object sender, EventArgs e)
        {
            string sql = "";
            //DateTime ngaydat, ngaygiao;

           // try
           // {
               // ngaydat = DateTime.ParseExact(mtbNgayDat.Text, "yyyy/mm/dd", CultureInfo.InvariantCulture);
              //  ngaygiao = DateTime.ParseExact(mtbNgayGiao.Text, "yyyy/mm/dd", CultureInfo.InvariantCulture);
            //} catch
            //{
                //mtbNgayDat.Select();
               // mtbNgayGiao.Select();
             //   return;
           // }

            string MaDH = txtMaDH.Text;
            string TrangThai = txtTrangThai.Text;
            string DiaChiGiao = txtDiaChiGiao.Text;
            string SDT = txtSDT.Text;
            string NgayDat = txtNgayDat.Text;
            string NgayGiao = txtNgayGiao.Text;
            string MoTa = txtMoTa.Text;
            string CuocPhi = txtCuocPhi.Text;
            string TongTien = txtTongTien.Text;
            string MaKH = txtMaKH.Text;
            string MaShipper = txtMaShipper.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mdh))
            {
                sql = "sp_ThemDonHang";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaDH",
                    value = MaDH
                });
            }
            else
            {
                sql = "sp_UpdateDonHang";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaDH",
                    value = MaDH
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@TrangThai",
                value = TrangThai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChiGiao",
                value = DiaChiGiao
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = SDT
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgayDat",
                value = NgayDat
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgayGiao",
                value = NgayDat
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MoTa",
                value = MoTa
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@CuocPhi",
                value = CuocPhi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TongTien",
                value = TongTien
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaKH",
                value = MaKH
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaShipper",
                value = MaShipper
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mdh))
                {
                    MessageBox.Show("Thêm mới đơn hàng thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật đơn hàng thành công");
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
