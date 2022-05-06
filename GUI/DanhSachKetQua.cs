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
    public partial class DanhSachKetQua : Form
    {
        public DanhSachKetQua()
        {
            InitializeComponent();
        }
        DSKQ_DTO DSKQ = new DSKQ_DTO();
        DSKQ_BUS dskq = new DSKQ_BUS();
        private void DanhSachKetQua_Load(object sender, EventArgs e)
        {
            //Load TenMonHoc
            Data da = new Data();
            string sql = "select * from MonHoc";
            cbTenMonHoc.DataSource = da.GetTable(sql);
            cbTenMonHoc.DisplayMember = "TenMonHoc";
            cbTenMonHoc.ValueMember = "MaMonHoc";
            //Load KetQua
            dgvDSKQ.DataSource = dskq.ShowDSKQ();
        }

        private void cbTenMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDSKQ.DataSource = dskq.ShowDSKQ_MonHoc(cbTenMonHoc.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDSKQ.DataSource = dskq.TimKiemKQ(txtTimKiem.Text);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DanhSachKetQua_Load(sender, e);
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
