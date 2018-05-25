using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.BUS;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_ThongTinSachChuaTra : UserControl
    {
        public frm_ThongTinSachChuaTra()
        {
            InitializeComponent();
            phieuMuon =  new PhieuMuon_BUS();
            KhoitaoCmb();
        }

        PhieuMuon_BUS phieuMuon;

        void KhoitaoCmb()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Tìm kiếm theo");
            table.Rows.Add("Mã phiếu mượn");
            table.Rows.Add("Mã thẻ");
            table.Rows.Add("Tên độc giả");
            table.Rows.Add("Ngày mượn");
            table.Rows.Add("Ngày dự kiến trả");
            cmbTimKiemTheo.DataSource = table;

        }
        void TimKiem()
        {

            string timKiemTheo;
            switch (cmbTimKiemTheo.Text)
            {
                case "Mã phiếu mượn":
                    timKiemTheo = "CHITIETMUON.MaPhieuMuon";
                    break;
                case "Mã thẻ":
                    timKiemTheo = "TheDocGia.MaThe";
                    break;
                case "Tên độc giả":
                    timKiemTheo = "TenDocGia";
                    break;
                case "Ngày mượn":
                    timKiemTheo = "PHIEUMUON.NgayMuon";
                    break;
                case "Ngày dự kiến trả":
                    timKiemTheo = "NgayDuKienTra";
                    break;
                default:
                    timKiemTheo = "CHITIETMUON.MaPhieuMuon";
                    break;
            }
                    dgvTTSachChuaTra.DataSource = phieuMuon.SearchTTSachChuaTra(timKiemTheo, txtTuCanTim.Text);
          
        }
        void STT()
        {
            for (int i = 0; i < dgvTTSachChuaTra.Rows.Count - 1; i++)
            {
                dgvTTSachChuaTra.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void frm_ThongTinSachChuaTra_Load(object sender, EventArgs e)
        {
            dgvTTSachChuaTra.DataSource = phieuMuon.SelectTTPMkhongTonTaiTrongMaPhieuTra();
            STT();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            TimKiem();
            STT();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            dgvTTSachChuaTra.DataSource = phieuMuon.SelectTTPMkhongTonTaiTrongMaPhieuTra();
        }

        private void txtTuCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TimKiem();
                STT();
            }
        }

        private void dgvTTSachChuaTra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTTSachChuaTra.CurrentRow.Index;
            frm_TTCTSachChuaTracs ttct = new frm_TTCTSachChuaTracs(dgvTTSachChuaTra[1,row].Value.ToString());
            ttct.ShowDialog();
        }
    }
}
