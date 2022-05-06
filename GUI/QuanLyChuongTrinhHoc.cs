using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using DTO;
using BUS;

namespace GUI
{
    public partial class QuanLyChuongTrinhHoc : Form
    {
        public QuanLyChuongTrinhHoc()
        {
            InitializeComponent();
        }
        ChuongTrinhHoc_DTO CTH = new ChuongTrinhHoc_DTO();
        ChuongTrinhHoc_BUS cth = new ChuongTrinhHoc_BUS();
        private void QuanLyChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            dgvChuongTrinhHoc.DataSource = cth.ShowChuongTrinhHoc();
        }

        private void dgvChuongTrinhHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaChuongTrinh.Text = dgvChuongTrinhHoc.Rows[dong].Cells[0].Value.ToString();
                txtTenChuongTrinh.Text = dgvChuongTrinhHoc.Rows[dong].Cells[1].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaChuongTrinh.TextLength == 0)
                MessageBox.Show("Ma chuong trinh khong duoc bo trong");
            else if (txtTenChuongTrinh.TextLength == 0)
                MessageBox.Show("Ten chuong trinh khong duoc bo trong");
            else
            {
                try
                {
                    CTH.MaChuongTrinh = txtMaChuongTrinh.Text;
                    CTH.TenChuongTrinh = txtTenChuongTrinh.Text;
                    cth.InsertChuongTrinhHoc(CTH.MaChuongTrinh, CTH.TenChuongTrinh);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyChuongTrinhHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaChuongTrinh.TextLength == 0)
                MessageBox.Show("Ma chuong trinh khong duoc bo trong");
            else if (txtTenChuongTrinh.TextLength == 0)
                MessageBox.Show("Ten chuong trinh khong duoc bo trong");
            else
            {
                try
                {
                    CTH.MaChuongTrinh = txtMaChuongTrinh.Text;
                    CTH.TenChuongTrinh = txtTenChuongTrinh.Text;
                    cth.UpdateChuongTrinhHoc(CTH.MaChuongTrinh, CTH.TenChuongTrinh);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyChuongTrinhHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChuongTrinh.TextLength == 0)
                MessageBox.Show("Chon ma chuong trinh de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        CTH.MaChuongTrinh = txtMaChuongTrinh.Text;
                        cth.DeleteChuongTrinhHoc(CTH.MaChuongTrinh);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyChuongTrinhHoc_Load(sender, e);
                    }
                    catch { MessageBox.Show("Co loi!"); }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult drl2 = MessageBox.Show("Ban co muon thoat!", "Thong bao", MessageBoxButtons.YesNo);
            if (drl2 == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
