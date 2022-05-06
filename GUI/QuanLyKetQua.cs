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
    public partial class QuanLyKetQua : Form
    {
        public QuanLyKetQua()
        {
            InitializeComponent();
        }
        KetQua_DTO KQ = new KetQua_DTO();
        KetQua_BUS kq = new KetQua_BUS();
        private void QuanLyKetQua_Load(object sender, EventArgs e)
        {
            //Load MaSinhVien
            Data da = new Data();
            string sql = "select * from SinhVien";
            cbMaSinhVien.DataSource = da.GetTable(sql);
            cbMaSinhVien.DisplayMember = "MaSinhVien";
            cbMaSinhVien.ValueMember = "MaSinhVien";
            //Load MaMonHoc
            Data da2 = new Data();
            string sql2 = "select * from MonHoc";
            cbMaMonHoc.DataSource = da2.GetTable(sql2);
            cbMaMonHoc.DisplayMember = "TenMonHoc";
            cbMaMonHoc.ValueMember = "MaMonHoc";
            //Load KetQua
            dgvKetQua.DataSource = kq.ShowKetQua();
        }

        private void dgvKetQua_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                cbMaSinhVien.SelectedValue = dgvKetQua.Rows[dong].Cells[0].Value.ToString();
                cbMaMonHoc.SelectedValue = dgvKetQua.Rows[dong].Cells[1].Value.ToString();
                txtLanThi.Text = dgvKetQua.Rows[dong].Cells[2].Value.ToString();
                txtDiemThi.Text = dgvKetQua.Rows[dong].Cells[3].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLanThi.TextLength == 0)
                MessageBox.Show("Lan thi khong duoc bo trong");
            else if (txtDiemThi.TextLength == 0)
                MessageBox.Show("Diem thi khong duoc bo trong");
            else
            {
                try
                {
                    KQ.MaSinhVien = cbMaSinhVien.SelectedValue.ToString();
                    KQ.MaMonHoc = cbMaMonHoc.SelectedValue.ToString();
                    KQ.LanThi = Int32.Parse(txtLanThi.Text);
                    KQ.DiemThi = float.Parse(txtDiemThi.Text);
                    kq.InsertKetQua(KQ.MaSinhVien, KQ.MaMonHoc, KQ.LanThi, KQ.DiemThi);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyKetQua_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtLanThi.TextLength == 0)
                MessageBox.Show("Lan thi khong duoc bo trong");
            else if (txtDiemThi.TextLength == 0)
                MessageBox.Show("Diem thi khong duoc bo trong");
            else
            {
                try
                {
                    KQ.MaSinhVien = cbMaSinhVien.SelectedValue.ToString();
                    KQ.MaMonHoc = cbMaMonHoc.SelectedValue.ToString();
                    KQ.LanThi = Int32.Parse(txtLanThi.Text);
                    KQ.DiemThi = float.Parse(txtDiemThi.Text);
                    kq.UpdateKetQua(KQ.MaSinhVien, KQ.MaMonHoc, KQ.LanThi, KQ.DiemThi);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyKetQua_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtLanThi.TextLength == 0)
                MessageBox.Show("Chon lan thi de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        KQ.MaSinhVien = cbMaSinhVien.SelectedValue.ToString();
                        KQ.MaMonHoc = cbMaMonHoc.SelectedValue.ToString();
                        KQ.LanThi = Int32.Parse(txtLanThi.Text);
                        kq.DeleteKetQua(KQ.MaSinhVien, KQ.MaMonHoc, KQ.LanThi);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyKetQua_Load(sender, e);
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
