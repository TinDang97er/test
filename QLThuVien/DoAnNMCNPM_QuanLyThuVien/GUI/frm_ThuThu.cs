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
using DoAnNMCNPM_QuanLyThuVien.DTO;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_ThuThu : UserControl
    {
        public frm_ThuThu()
        {
            InitializeComponent();
            thuthuBUS = new ThuThu_BUS();
            thuthuDTO = new ThuThu_DTO();
            KhoiTaoCmbChucVu();
            KhoiTaoCmbTiemKiem();
        }

        ThuThu_DTO thuthuDTO;
        ThuThu_BUS thuthuBUS;

        void Lock()
        {
            txtMaThuThu.Enabled = false;
            txtHoTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            cmbChucVu.Enabled = false;
        }

        void UnLock()
        {           
            txtHoTen.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            cmbChucVu.Enabled = true;
        }

        void Forcus()
        {
            txtMaThuThu.Text = "";
            txtHoTen.Text = "";
            dtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            cmbChucVu.Text = "";
    
        }

        void KhoiTaoCmbChucVu()
        {
            DataTable chucVu = new DataTable();
            chucVu.Columns.Add("Chức vụ ");
            chucVu.Rows.Add("Thủ thư");
            chucVu.Rows.Add("Phó phòng");
            chucVu.Rows.Add("Trưởng phòng");
            cmbChucVu.DataSource = chucVu;
 
        }

        void KhoiTaoCmbTiemKiem()
        {
            DataTable Loai = new DataTable();        
            Loai.Columns.Add("Tìm kiếm theo");
            Loai.Rows.Add("Mã thủ thư");
            Loai.Rows.Add("Tên thủ thư");
            Loai.Rows.Add("Địa chỉ");
            Loai.Rows.Add("Email");
            Loai.Rows.Add("Giới tính");
            cmbTimKiemTheo.DataSource = Loai;
        }

        void STT()
        {
            for (int i = 0; i < dgvDanhSachThuThu.Rows.Count - 1; i++)
            {
                dgvDanhSachThuThu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // khoi tao cac gia tri cho doi tuong thuthuDTO
        void KhoiTaoDTO()
        {
            thuthuDTO.MaThuThu = txtMaThuThu.Text.Trim();
            thuthuDTO.HoTen = txtHoTen.Text.Trim();          
                if (chkNam.IsChecked)
                    thuthuDTO.GioiTinh = "Nam";
                else
                    thuthuDTO.GioiTinh = "Nữ";          
            thuthuDTO.NgaySinh = dtNgaySinh.Text.Trim();
            thuthuDTO.DiaChi = txtDiaChi.Text.Trim();
            thuthuDTO.Email = txtEmail.Text.Trim();
            thuthuDTO.ChucVu = cmbChucVu.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLock();
            Forcus();
            TangMaTuDong();
            txtHoTen.Focus();
        }

        void TangMaTuDong()
        {
            int count = dgvDanhSachThuThu.Rows.Count;
            if (count > 2)
            {
                int Chuoi = 0;
                string strChuoi = "";
                strChuoi = Convert.ToString(dgvDanhSachThuThu.Rows[count - 2].Cells[1].Value);
                Chuoi = Convert.ToInt32(strChuoi.Remove(0, 2));

                if (Chuoi + 1 < 10)
                    txtMaThuThu.Text = "TT0" + (Chuoi + 1).ToString();
                else
                {
                    txtMaThuThu.Text = "TT" + (Chuoi + 1).ToString();

                }
            }
            else
                txtMaThuThu.Text = "TT00";
            
        }

        private void frm_ThuThu_Load(object sender, EventArgs e)
        {
            
            dgvDanhSachThuThu.DataSource = thuthuBUS.Select();
            chkNam.IsChecked = true;           
            STT();
            Lock();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (!thuthuBUS.KiemTra(thuthuDTO))
                    MessageBox.Show("Thông tin thủ thư không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (!thuthuBUS.Delete(thuthuDTO))
                        MessageBox.Show("Xóa thủ thư không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa thủ thư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvDanhSachThuThu.DataSource = thuthuBUS.Select();
                STT();
                Forcus();
                TangMaTuDong();
                txtHoTen.Focus();
            }
            catch
            {
                MessageBox.Show("Thông tin thủ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                try
                {
                    KhoiTaoDTO();   
                    if((DateTime.Now.Year -dtNgaySinh.Value.Year )>=23)
                     {
                        if (!thuthuBUS.KiemTra(thuthuDTO))
                            MessageBox.Show("Thông tin thủ thư không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            if (thuthuBUS.Insert(thuthuDTO))
                            {
                                MessageBox.Show("Thêm Thủ thư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDanhSachThuThu.DataSource = thuthuBUS.Select();
                                STT();
                            }

                            else
                                MessageBox.Show("Thêm thủ thư không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Forcus();
                        TangMaTuDong();
                       txtHoTen.Focus();
                    

                    }
                    else
                    {
                    MessageBox.Show("Tuổi thủ thư phải lớn hơn 22!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
                catch
                {
                    MessageBox.Show("Thông tin thủ thư không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
         }   
        // lay thong tin tu bang de dua bao bien thuthuDTO
        private void dgvDanhSachThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UnLock();
            txtMaThuThu.ReadOnly = true;
            int row = dgvDanhSachThuThu.CurrentRow.Index;
            txtMaThuThu.Text = dgvDanhSachThuThu[1, row].Value.ToString();
            txtHoTen.Text = dgvDanhSachThuThu[2, row].Value.ToString();
           string GioiTinh = dgvDanhSachThuThu[3, row].Value.ToString().Trim();
            if (GioiTinh.Equals("Nam"))
            {
                chkNam.IsChecked = true;                
            }
            else
            {               
                chkNu.IsChecked = true;       
            }
            dtNgaySinh.Text = dgvDanhSachThuThu[4, row].Value.ToString();
            txtDiaChi.Text = dgvDanhSachThuThu[5, row].Value.ToString();
            txtEmail.Text = dgvDanhSachThuThu[6, row].Value.ToString();
            cmbChucVu.Text = dgvDanhSachThuThu[7, row].Value.ToString();
       }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (!thuthuBUS.KiemTra(thuthuDTO))
                    MessageBox.Show("Thông tin thủ thư không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (thuthuBUS.Update(thuthuDTO))
                    {
                        MessageBox.Show("Cập nhập thủ thư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachThuThu.DataSource = thuthuBUS.Select();
                        STT();
                    }
                    else
                        MessageBox.Show("Cập nhập thủ thư không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         
                Forcus();
                TangMaTuDong();
                txtHoTen.Focus();

            }catch
            {
                MessageBox.Show("Thông tin thủ thư không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtTuCanTim.Text = "";
            dgvDanhSachThuThu.DataSource = thuthuBUS.Select();
            STT();
        }

        void TimKiem()
        {
            string timKiemTheo = "";
            switch (cmbTimKiemTheo.Text.Trim())
            {
                case "Mã thủ thư":
                    timKiemTheo = "MaThuThu";
                    break;
                case "Tên thủ thư":
                    timKiemTheo = "TenThuThu";
                    break;
                case "Địa chỉ":
                    timKiemTheo = "DiaChi";
                    break;
                case "Email":
                    timKiemTheo = "Email";
                    break;
                case "Giới tính":
                    timKiemTheo = "GioiTinh";
                    break;
                default:
                    timKiemTheo = "MaThuThu";
                    break;

            }

            dgvDanhSachThuThu.DataSource = thuthuBUS.Search(timKiemTheo, txtTuCanTim.Text);
            STT();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            TimKiem();          
        }
        
        private void txtMaThuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                txtHoTen.Focus();
            }
        }

        private void dtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbChucVu.Focus();
            }
        }

        private void txtTuCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                TimKiem();
            }
        }

        private void txtMaThuThu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
