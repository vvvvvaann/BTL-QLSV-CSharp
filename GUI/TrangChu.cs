using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLSV = new QuanLySinhVien();
            frmQLSV.MdiParent = this;
            frmQLSV.Show();
        }

        private void lopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLL = new QuanLyLop();
            frmQLL.MdiParent = this;
            frmQLL.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLK = new QuanLyKhoa();
            frmQLK.MdiParent = this;
            frmQLK.Show();
        }

        private void khoaHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLKH = new QuanLyKhoaHoc();
            frmQLKH.MdiParent = this;
            frmQLKH.Show();
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLMH = new QuanLyMonHoc();
            frmQLMH.MdiParent = this;
            frmQLMH.Show();
        }

        private void giangKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLGK = new QuanLyGiangKhoa();
            frmQLGK.MdiParent = this;
            frmQLGK.Show();
        }

        private void chuongTrinhHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLCTH = new QuanLyChuongTrinhHoc();
            frmQLCTH.MdiParent = this;
            frmQLCTH.Show();
        }

        private void ketQuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmQLKQ = new QuanLyKetQua();
            frmQLKQ.MdiParent = this;
            frmQLKQ.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drl2 = MessageBox.Show("Ban co muon thoat!", "Thong bao", MessageBoxButtons.YesNo);
            if (drl2 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sinhVienToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var frmDSSV = new DanhSachSinhVien();
            frmDSSV.MdiParent = this;
            frmDSSV.Show();
        }

        private void ketQuaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var frmDSKQ = new DanhSachKetQua();
            frmDSKQ.MdiParent = this;
            frmDSKQ.Show();
        }
    }
}
