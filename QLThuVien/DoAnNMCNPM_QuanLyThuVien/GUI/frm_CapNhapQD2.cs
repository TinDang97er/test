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
using DoAnNMCNPM_QuanLyThuVien.GUI;

namespace DoAnNMCNPM_QuanLyThuVien
{
    public partial class frm_CapNhapQD2 : Form
    {
        public frm_CapNhapQD2()
        {
            InitializeComponent();
            qdBUS = new QuyDinh2_BUS();
            qdDTO = new QuyDinh2_DTO();
            kiemTra = true;
            XacNhanCapNhap = false;

         
        }
        
        QuyDinh2_BUS qdBUS;
        QuyDinh2_DTO qdDTO;
        bool kiemTra;
        bool XacNhanCapNhap;
        int soTheLoaiCu;

        private void frm_CapNhapQD2_Load(object sender, EventArgs e)
        {
            txtSoTheLoai.Focus();
            DataTable table = new DataTable();
            table = qdBUS.Select();
            try
            {
                var i = table.Rows[0].ItemArray;
                txtSoTheLoai.Text = i[0].ToString();
                txtHanNhanSach.Text = i[1].ToString();
                soTheLoaiCu = int.Parse(txtSoTheLoai.Text);
                
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
                
                if((int.Parse(txtSoTheLoai.Text)==soTheLoaiCu && kiemTra) || (int.Parse(txtSoTheLoai.Text) != soTheLoaiCu && kiemTra && XacNhanCapNhap))
                {
                    qdDTO.SoTheLoai = int.Parse(txtSoTheLoai.Text);
                    qdDTO.HanNhanSach = int.Parse(txtHanNhanSach.Text);
                    if (qdBUS.KiemTra(qdDTO) && qdBUS.Update(qdDTO))
                    {
                        MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa cập nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               

            }
            catch
            {
                MessageBox.Show("Thông tin nhập không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSoTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
              

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                int soTheLoai = int.Parse(txtSoTheLoai.Text);
                if (soTheLoai > 0)
                {
                    frm_TheLoai theLoai = new frm_TheLoai(soTheLoai);
                    theLoai.ShowDialog();
                    txtHanNhanSach.Focus();
                    kiemTra = frm_TheLoai.kiemtra;
                    XacNhanCapNhap = frm_TheLoai.xacNhanCapNhap;
                }
                else
                {
                    MessageBox.Show("Số thể loại phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Số thể loại là một số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
