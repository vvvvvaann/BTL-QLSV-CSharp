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
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class QuanLyKhoa : Form
    {
        public QuanLyKhoa()
        {
            InitializeComponent();
        }
        Khoa_DTO K = new Khoa_DTO();
        Khoa_BUS k = new Khoa_BUS();
        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = k.ShowKhoa();
        }

        private void dgvKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaKhoa.Text = dgvKhoa.Rows[dong].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvKhoa.Rows[dong].Cells[1].Value.ToString();
                txtNamThanhLap.Text = dgvKhoa.Rows[dong].Cells[2].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Ma khoa khong duoc bo trong");
            else if (txtTenKhoa.TextLength == 0)
                MessageBox.Show("Ten khoa khong duoc bo trong");
            else if (txtNamThanhLap.TextLength == 0)
                MessageBox.Show("Nam thanh lap khong duoc bo trong");
            else
            {
                try
                {
                    K.MaKhoa = txtMaKhoa.Text;
                    K.TenKhoa = txtTenKhoa.Text;
                    K.NamThanhLap = Int32.Parse(txtNamThanhLap.Text);
                    k.InsertKhoa(K.MaKhoa, K.TenKhoa, K.NamThanhLap);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyKhoa_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Ma khoa khong duoc bo trong");
            else if (txtTenKhoa.TextLength == 0)
                MessageBox.Show("Ten khoa khong duoc bo trong");
            else if (txtNamThanhLap.TextLength == 0)
                MessageBox.Show("Nam thanh lap khong duoc bo trong");
            else
            {
                try
                {
                    K.MaKhoa = txtMaKhoa.Text;
                    K.TenKhoa = txtTenKhoa.Text;
                    K.NamThanhLap = Int32.Parse(txtNamThanhLap.Text);
                    k.UpdateKhoa(K.MaKhoa, K.TenKhoa, K.NamThanhLap);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyKhoa_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Chon ma khoa de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        K.MaKhoa = txtMaKhoa.Text;
                        k.DeleteKhoa(K.MaKhoa);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyKhoa_Load(sender, e);
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
