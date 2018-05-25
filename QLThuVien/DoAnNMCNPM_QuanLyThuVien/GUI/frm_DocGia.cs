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
    public partial class frm_DocGia : UserControl
    {
        public frm_DocGia()
        {
            InitializeComponent();
            docgiaBUS = new DocGia_BUS();
            docgiaDTO = new DocGia_DTO();
            qd1 = new QuyDinh1_BUS();
            DataTable table = qd1.Select();
            var i = table.Rows[0].ItemArray;
            TuoiMin = int.Parse(i[0].ToString());
            TuoiMax = int.Parse(i[1].ToString());
            KhoiTaoCmbTiemKiem();
            
        }

        DocGia_DTO docgiaDTO;
        DocGia_BUS docgiaBUS;
        int TuoiMin;
        int TuoiMax;
        QuyDinh1_BUS qd1;

        void Lock()
        {
            txtMaDocGia.Enabled = false;
            txtHoTen.Enabled = false;
            chkNam.Enabled = false;
            chkNu.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;

        }

        void UnLock()
        {           
            txtHoTen.Enabled = true;
            chkNam.Enabled = true;
            chkNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
        }

        void Forcus()
        {
            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            dtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";         
        }

        void KhoiTaoCmbTiemKiem()
        {
            DataTable Loai = new DataTable();
            Loai.Columns.Add("Tìm kiếm theo");
            Loai.Rows.Add("Mã độc giả");
            Loai.Rows.Add("Tên độc giả");
            Loai.Rows.Add("Giới tính");
            Loai.Rows.Add("Ngày sinh");
            Loai.Rows.Add("Địa chỉ");
            Loai.Rows.Add("Email");
            cmbTimKiemTheo.DataSource = Loai;
        }

        void KhoiTaoDTO()
        {
            docgiaDTO.MaDocGia = txtMaDocGia.Text.Trim();
            docgiaDTO.HoTen = txtHoTen.Text.Trim();
            if (chkNam.IsChecked)
                docgiaDTO.GioiTinh = "Nam";
            else
                docgiaDTO.GioiTinh = "Nữ";

            docgiaDTO.NgaySinh = dtNgaySinh.Value.ToShortDateString();
            docgiaDTO.DiaChi = txtDiaChi.Text.Trim();
            docgiaDTO.Email = txtEmail.Text.Trim();

        }

        void TangMaTuDong()
        {
            int count = dgvDanhSachDocGia.Rows.Count;
            if (count > 2)
            {
                int Chuoi = 0;
                string strChuoi = "";
                strChuoi = Convert.ToString(dgvDanhSachDocGia.Rows[count - 2].Cells[1].Value);
                Chuoi = Convert.ToInt32(strChuoi.Remove(0, 2));

                if (Chuoi + 1 < 10)
                    txtMaDocGia.Text = "DG000" + (Chuoi + 1).ToString();
                else
                {
                    if (Chuoi + 1 < 100)
                        txtMaDocGia.Text = "DG00" + (Chuoi + 1).ToString();
                    else
                    {
                        if (Chuoi + 1 < 1000)
                            txtMaDocGia.Text = "DG0" + (Chuoi + 1).ToString();
                        else
                            txtMaDocGia.Text = "DG" + (Chuoi + 1).ToString();
                    }
                }
            }
            else
            {
                txtMaDocGia.Text = "MS0000";
            }

        }

        void STT()
        {
            for (int i = 0; i < dgvDanhSachDocGia.Rows.Count - 1; i++)
            {
                dgvDanhSachDocGia.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void txtMaDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtHoTen.Focus();
        }

        private void dtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
               txtDiaChi.Focus();
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtEmail.Focus();
        }

        private void txtTimKiemTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTuCanTim.Focus();
        }

        private void frm_DocGia_Load(object sender, EventArgs e)
        {
            chkNam.IsChecked = true;
            txtMaDocGia.Focus();
            dgvDanhSachDocGia.DataSource = docgiaBUS.Select();
            STT();
            Lock();  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (docgiaBUS.KiemTra(docgiaDTO))
                {
                    if (docgiaBUS.Delete(docgiaDTO))
                    {
                        MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachDocGia.DataSource = docgiaBUS.Select();
                        STT();
                    }
                    else
                        MessageBox.Show("Xóa độc giả không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    TangMaTuDong();
                    txtMaDocGia.Focus();
                }
                else
                    MessageBox.Show("Thông tin độc giả cần xóa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch
            {
                MessageBox.Show("Thông tin độc giả cần không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (docgiaBUS.KiemTra(docgiaDTO))
                {
                    int tuoiDocGia;
                    string strTuoiDocGia;
                    TimeSpan tstuoi = DateTime.Now - dtNgaySinh.Value;
                     strTuoiDocGia= (tstuoi.TotalDays / 365).ToString();
                    var Tuoi = strTuoiDocGia.Split('.');
                    tuoiDocGia = int.Parse(Tuoi[0]);
                    if(tuoiDocGia<TuoiMax && tuoiDocGia>TuoiMin)
                    {
                        if (docgiaBUS.Insert(docgiaDTO))
                        {
                            MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvDanhSachDocGia.DataSource = docgiaBUS.Select();
                            STT();

                        }
                        else
                            MessageBox.Show("Thêm độc giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Forcus();                 
                        TangMaTuDong();
                        txtHoTen.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Tuổi độc giả từ " + TuoiMin + " đến " + TuoiMax + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    }               
                }
                else
                    MessageBox.Show("Thông tin độc giả không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Thông tin độc giả không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
                  
        }
 
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (docgiaBUS.KiemTra(docgiaDTO))
                {
                    if (docgiaBUS.UpDate(docgiaDTO))
                    {
                        MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachDocGia.DataSource = docgiaBUS.Select();
                        STT();

                    }
                    else
                        MessageBox.Show("Cập nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    TangMaTuDong();
                    txtMaDocGia.Focus();
                }
                else
                    MessageBox.Show("Thông tin cập nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Thông tin cập nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                              
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dgvDanhSachDocGia.DataSource = docgiaBUS.Select();
            STT();
            txtTuCanTim.Text = "";
        }

        void  TimKiem()
        {
          

            string timKiemTheo = "";
            switch (cmbTimKiemTheo.Text.Trim())
            {
                case "Mã độc giả":
                    timKiemTheo = "MaDocGia";
                    break;
                case "Tên độc giả":
                    timKiemTheo = "TenDocGia";
                    break;
                case "Giới tính":
                    timKiemTheo = "GioiTinh";
                    break;
                case "Ngày sinh":
                    timKiemTheo = "NgaySinh";
                    break;
                case "Địa chỉ":
                    timKiemTheo = "DiaChi";
                    break;
                case "Email":
                    timKiemTheo = "Email";
                    break;
                default:
                    timKiemTheo = "MaSach";
                    break;
            }
            dgvDanhSachDocGia.DataSource = docgiaBUS.Search(timKiemTheo, txtTuCanTim.Text);
            STT();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dgvDanhSachDocGia_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            UnLock();
            txtMaDocGia.ReadOnly = true;
            int row = dgvDanhSachDocGia.CurrentRow.Index;
            txtMaDocGia.Text = dgvDanhSachDocGia[1, row].Value.ToString();
            txtHoTen.Text = dgvDanhSachDocGia[2, row].Value.ToString();
            string GioiTinh = dgvDanhSachDocGia[3, row].Value.ToString().Trim();
            if (GioiTinh.Equals("Nam"))
            {
                chkNam.IsChecked = true;
               
            }
            else
            {              
                chkNu.IsChecked = true;              
            }
            dtNgaySinh.Text = dgvDanhSachDocGia[4, row].Value.ToString();
            txtDiaChi.Text = dgvDanhSachDocGia[5, row].Value.ToString();
            txtEmail.Text = dgvDanhSachDocGia[6, row].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLock();
            Forcus();
            TangMaTuDong();
            txtHoTen.Focus();
            
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
