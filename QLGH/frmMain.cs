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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string taikhoan;
        private string loaitk;

        private void frmMain_Load(object sender, EventArgs e)
        {
            // var db = new Database();
            //dgvData.DataSource = db.SelectData(null);
            //IsMdiContainer = true;
            var fn = new frmDangNhap();
            fn.ShowDialog();

            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            // nếu tk là user ẩn 2 mục đơn hàng và thông tin khách hàng khác
            //BUG: ko đăng nhập vẫn auto vào account "User"
            if (loaitk.Equals("User"))
            {
                khachHangToolStripMenuItem.Visible = false;
                donHangToolStripMenuItem.Visible = false;
                
            }
            frmWelcome f = new frmWelcome();
            AddForm(f);

        }
        private void AddForm(Form f)
        {
            //frmShiipper f = new frmShiipper();
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
           // frmDangNhap f = new frmDangNhap();
            //AddForm(f);
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSKH f = new frmDSKH();
            AddForm(f);
        }

        private void shipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShiipper f = new frmShiipper();
            AddForm(f);
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSP f = new frmDSSP();
            AddForm(f);
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLOAISP f = new frmDSLOAISP();
            AddForm(f);
        }

        private void donHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDH f = new frmDSDH();
            AddForm(f);
        }
        // Phần dưới làm dư
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSP f = new frmDSSP();
            AddForm(f);
        }

        private void loaiSanPhamUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLOAISP f = new frmDSLOAISP();
            AddForm(f);
        }

        private void shipperUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShiipper f = new frmShiipper();
            AddForm(f);
        }
    }
}
