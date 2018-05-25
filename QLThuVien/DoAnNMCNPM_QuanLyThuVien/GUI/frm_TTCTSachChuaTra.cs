using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.BUS;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_TTCTSachChuaTracs : Form
    {
        public frm_TTCTSachChuaTracs(string _maPhieuMuon)
        {
            InitializeComponent();
            phieuMuon = new PhieuMuon_BUS();
            maPhieuMuon = _maPhieuMuon;

        }
        string maPhieuMuon;
        PhieuMuon_BUS phieuMuon;
        private void frm_TTCTSachChuaTracs_Load(object sender, EventArgs e)
        {
            dgvCTsachChuaTra.DataSource = phieuMuon.SelectTTCTSachChuaTra(maPhieuMuon);
            STT();
        }

        void STT()
        {
            for (int i = 0; i < dgvCTsachChuaTra.Rows.Count - 1; i++)
            {
                dgvCTsachChuaTra.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
