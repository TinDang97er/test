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
    public partial class Frm_CapNhapQD1 : Form
    {
        public Frm_CapNhapQD1()
        {
            InitializeComponent();
            qdBUS = new QuyDinh1_BUS();
            qdDTO = new QuyDinh1_DTO();           
        }

        QuyDinh1_BUS qdBUS;
        QuyDinh1_DTO qdDTO;

        private void Frm_CapNhapQD1_Load(object sender, EventArgs e)
        {
            txtTuoiDocGiaTu.Focus();
            DataTable table = qdBUS.Select();
            try
            {
                var i = table.Rows[0].ItemArray;
                txtTuoiDocGiaTu.Text = i[0].ToString();
                txtDen.Text = i[1].ToString();
                txtHanThe.Text = i[2].ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                qdDTO.TuoiMin = int.Parse(txtTuoiDocGiaTu.Text);
                qdDTO.TuoiMax = int.Parse(txtDen.Text);
                qdDTO.HanThe = int.Parse(txtHanThe.Text);
                if (qdBUS.KiemTra(qdDTO) && qdBUS.Update(qdDTO))
                {
                    MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Cập nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thông tin nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

           
        }

        private void txtTuoiDocGiaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtDen.Focus();
        }

        private void txtDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtHanThe.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTuoiDocGiaTu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
