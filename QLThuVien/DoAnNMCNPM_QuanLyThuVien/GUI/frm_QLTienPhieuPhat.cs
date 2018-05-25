using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.BUS;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_QLTienPhieuPhat : UserControl
    {
        public frm_QLTienPhieuPhat()
        {
            InitializeComponent();
            phieuTienPhatBUS = new PhieuPhat_BUS();
            KhoiTaoCmbTimKiem();

        }

        PhieuPhat_BUS phieuTienPhatBUS;

        float tongTien = 0;

       void KhoiTaoCmbTimKiem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Tìm kiếm theo:");
            table.Rows.Add("Mã phiếu trả");
            table.Rows.Add("Tổng nợ");
            cmbTimKiemTheo.DataSource = table;
        }

        void STT()
        {
            for (int i = 0; i < dgvDanhSachPhieuPhat.Rows.Count - 1; i++)
            {
                dgvDanhSachPhieuPhat.Rows[i].Cells[0].Value = i + 1;
            }
        }

        void TimKiem()
        {
           
            string timKiemTheo = "";
            switch (cmbTimKiemTheo.Text.Trim())
            {
                case "Mã phiếu trả":
                    timKiemTheo = "MaPhieuTra";
                    break;
                case "Tổng nợ":
                    timKiemTheo = "TongNo";
                    break;             
                default:
                    timKiemTheo = "MaPhieuTra";
                    break;
            }
            dgvDanhSachPhieuPhat.DataSource = phieuTienPhatBUS.Search(timKiemTheo, txtTuCanTim.Text);
            STT();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();          
        }

        private void frm_QLTienPhieuPhat_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTimKiemTheo.Focus();

                dgvDanhSachPhieuPhat.DataSource = phieuTienPhatBUS.Select();

                STT();

                for (int i = 0; i < dgvDanhSachPhieuPhat.Rows.Count - 1; i++)
                {
                    tongTien += float.Parse(dgvDanhSachPhieuPhat[2, i].Value.ToString());
                }

                lbTongTienThu.Text = tongTien.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuPhat.DataSource = phieuTienPhatBUS.Select();
            STT();
            txtTuCanTim.Text = "";
        }

        private void txtTimKiemTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTuCanTim.Focus();
        }

       
        private void txtTuCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                TimKiem();
                
            }
        }
    }
}
