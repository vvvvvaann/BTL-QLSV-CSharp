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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        MonHoc_DTO MH = new MonHoc_DTO();
        MonHoc_BUS mh = new MonHoc_BUS();
        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            //Load MaKhoa
            Data da = new Data();
            string sql = "select * from Khoa";
            cbMaKhoa.DataSource = da.GetTable(sql);
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
            //Load MonHoc
            dgvMonHoc.DataSource = mh.ShowMonHoc();
        }

        private void dgvMonHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaMonHoc.Text = dgvMonHoc.Rows[dong].Cells[0].Value.ToString();
                cbMaKhoa.SelectedValue = dgvMonHoc.Rows[dong].Cells[1].Value.ToString();
                txtTenMonHoc.Text = dgvMonHoc.Rows[dong].Cells[2].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextLength == 0)
                MessageBox.Show("Ma mon hoc khong duoc bo trong");
            else if (txtTenMonHoc.TextLength == 0)
                MessageBox.Show("Ten mon hoc khong duoc bo trong");
            else
            {
                try
                {
                    MH.MaMonHoc = txtMaMonHoc.Text;
                    MH.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                    MH.TenMonHoc = txtTenMonHoc.Text;
                    mh.InsertMonHoc(MH.MaMonHoc, MH.MaKhoa, MH.TenMonHoc);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyMonHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextLength == 0)
                MessageBox.Show("Ma mon hoc khong duoc bo trong");
            else if (txtTenMonHoc.TextLength == 0)
                MessageBox.Show("Ten mon hoc khong duoc bo trong");
            else
            {
                try
                {
                    MH.MaMonHoc = txtMaMonHoc.Text;
                    MH.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                    MH.TenMonHoc = txtTenMonHoc.Text;
                    mh.UpdateMonHoc(MH.MaMonHoc, MH.MaKhoa, MH.TenMonHoc);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyMonHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextLength == 0)
                MessageBox.Show("Chon ma mon hoc de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        MH.MaMonHoc = txtMaMonHoc.Text;
                        mh.DeleteMonHoc(MH.MaMonHoc);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyMonHoc_Load(sender, e);
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
