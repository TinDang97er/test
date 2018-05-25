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
using DoAnNMCNPM_QuanLyThuVien.DTO;

namespace DoAnNMCNPM_QuanLyThuVien
{
    public partial class Frm_CapNhapQD3 : Form
    {
        public Frm_CapNhapQD3()
        {
            InitializeComponent();
            qdBUS = new QuyDinh3_BUS();
            qdDTO = new QuyDinh3_DTO();
        }

        QuyDinh3_BUS qdBUS;
        QuyDinh3_DTO qdDTO;

        private void Frm_CapNhapQD3_Load(object sender, EventArgs e)
        {
            txtSoSachMuonToiDa.Focus();
            DataTable table = new DataTable();
            table = qdBUS.Select();
            try
            {
                var i = table.Rows[0].ItemArray;
               txtSoSachMuonToiDa.Text = i[0].ToString();
                txtSoNgayMuonToiDa.Text = i[1].ToString();
              
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                qdDTO.SoLuongSachToiDa = int.Parse(txtSoSachMuonToiDa.Text);
                qdDTO.SoNgayMuonToiDa = int.Parse(txtSoNgayMuonToiDa.Text);
                if(qdBUS.KiemTra(qdDTO)&& qdBUS.Update(qdDTO))
                {
                    MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Kiểu dử liệu bạn nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoNgayMuonToiDa.Text = "";
                txtSoSachMuonToiDa.Text = "";

            }
        }

        private void txtSoSachMuonToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtSoNgayMuonToiDa.Focus();
        }
    }
}
