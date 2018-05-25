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
    public partial class frm_PhieuDocGia : UserControl
    {
        public frm_PhieuDocGia()
        {
            InitializeComponent();
            thedocgiaBUS = new TheDocGia_BUS();
            thedocgiaDTO = new TheDocGia_DTO();
            qd = new QuyDinh1_BUS();
            DataTable table = qd.Select();
            var i = table.Rows[0].ItemArray;
            dtNgayLamThe.Text = DateTime.Now.ToShortDateString();
            dthanThe.Text = DateTime.Now.AddMonths(int.Parse(i[2].ToString())).ToShortDateString();
            KhoiTaoCmbTiemKiem();
            KhoiTaoCmbLoaiThe();
        }

        TheDocGia_DTO thedocgiaDTO;
        TheDocGia_BUS thedocgiaBUS;
        QuyDinh1_BUS qd;

       
        void Lock()
        {
            txtMaThe.Enabled = false;
            txtMaDocGia.Enabled = false;
            txtHoTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            dtNgayLamThe.Enabled = false;
            dthanThe.Enabled = false;
            cmbLoaiThe.Enabled = false;

        }

        void UnLock()
        {          
            txtMaDocGia.Enabled = true;
            txtHoTen.Enabled = true;
            dtNgaySinh.Enabled = true;
            dtNgayLamThe.Enabled = true;
            dthanThe.Enabled = true;
            cmbLoaiThe.Enabled = true;

        }

        void Forcus()
        {
            txtMaThe.Text = "";
            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            dtNgayLamThe.Text = DateTime.Now.ToShortDateString(); ;
            dthanThe.Value = DateTime.Now.AddMonths(6);
            cmbLoaiThe.Text = "";
            dtNgaySinh.Text = "";

        }

        void KhoiTaoCmbLoaiThe()
        {
            DataTable loaiThe = new DataTable();
            loaiThe.Columns.Add("Loại thẻ ");
            loaiThe.Rows.Add("A");
            loaiThe.Rows.Add("B");
            cmbLoaiThe.DataSource = loaiThe;
        }

        void KhoiTaoCmbTiemKiem()
        {
            DataTable Loai = new DataTable();
            Loai.Columns.Add("Tìm kiếm theo!");
            Loai.Rows.Add("Ma thẻ");
            Loai.Rows.Add("Mã độc giả");
            Loai.Rows.Add("Ngày làm thẻ");
            Loai.Rows.Add("Hạn thẻ");
            Loai.Rows.Add("Loại thẻ");
            cmbTimKiemTheo.DataSource = Loai;
        }

        void KhoiTaoDTO()
        {
            thedocgiaDTO.MaThe = txtMaThe.Text.Trim();
            thedocgiaDTO.MaDocGia = txtMaDocGia.Text.Trim();
            thedocgiaDTO.NgayLamThe = dtNgayLamThe.Text.Trim();
            thedocgiaDTO.HanThe = dthanThe.Text.Trim();
            thedocgiaDTO.LoaiThe = cmbLoaiThe.Text.Trim();
        }

        void TangMaTuDong()
        {
            int count = dgvDanhSachTheDocGia.Rows.Count;
            if (count > 2)
            {
                int Chuoi = 0;
                string strChuoi = "";
                strChuoi = Convert.ToString(dgvDanhSachTheDocGia.Rows[count - 2].Cells[1].Value);
                Chuoi = Convert.ToInt32(strChuoi.Remove(0, 2));

                if (Chuoi + 1 < 10)
                    txtMaThe.Text = "MT000" + (Chuoi + 1).ToString();
                else
                {
                    if (Chuoi + 1 < 100)
                        txtMaThe.Text = "MT00" + (Chuoi + 1).ToString();
                    else
                    {
                        if (Chuoi + 1 < 1000)
                            txtMaThe.Text = "MT0" + (Chuoi + 1).ToString();
                        else
                            txtMaThe.Text = "MT" + (Chuoi + 1).ToString();
                    }

                }
            }
            else
            {
                txtMaThe.Text = "MT0000";
            }

        }

        void STT()
        {
            for (int i = 0; i < dgvDanhSachTheDocGia.Rows.Count - 1; i++)
            {
                dgvDanhSachTheDocGia.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void cmbTimKiemTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTuCanTim.Focus();
        }

        private void frm_PhieuDocGia_Load(object sender, EventArgs e)
        {
                     
            dgvDanhSachTheDocGia.DataSource = thedocgiaBUS.Select();
            STT();
            Lock();
            txtMaThe.Focus();
        }

        private void txtMaThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtMaDocGia.Focus();
        }

        private void txtMaDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (txtMaDocGia.Text.Trim() != "")
                    {
                        if (!thedocgiaBUS.KTDocGiaCoTonTaiTrongDsThe(txtMaDocGia.Text))
                        {
                            DataTable table = thedocgiaBUS.TimTenNgaySinhDocGia(txtMaDocGia.Text);
                            var tenNgaySinh = table.Rows[0].ItemArray;
                            txtHoTen.Text = tenNgaySinh[0].ToString();
                            dtNgaySinh.Text = tenNgaySinh[1].ToString();
                        }
                        else
                            MessageBox.Show("Độc giả đã tồn tại trong danh sách thẻ độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                    }
                    else
                        MessageBox.Show("Mã độc giả trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                   
                }
                catch
                {
                    MessageBox.Show("Mã độc giả không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
               
        }
 
        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLock();
            Forcus();          
            TangMaTuDong();
            txtMaDocGia.Focus();
        }

     
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                
                if (thedocgiaBUS.KiemTra(thedocgiaDTO))
                {
                    if (thedocgiaBUS.Delete(thedocgiaDTO))
                    {
                        MessageBox.Show("Xóa thẻ độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachTheDocGia.DataSource = thedocgiaBUS.Select();
                        STT();

                    }
                    else
                        MessageBox.Show("Xóa thẻ độc giả không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    TangMaTuDong();
                    txtMaDocGia.Focus();
                    txtMaDocGia.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin thẻ cần xóa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin thẻ cần xóa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text != "")
                {
                    KhoiTaoDTO();
                    if (thedocgiaBUS.KiemTra(thedocgiaDTO))
                    {

                        if (thedocgiaBUS.Insert(thedocgiaDTO))
                        {
                            MessageBox.Show("Thêm thẻ độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvDanhSachTheDocGia.DataSource = thedocgiaBUS.Select();
                            STT();
                        }
                        else
                            MessageBox.Show("Thêm thẻ độc giả không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Forcus();
                        TangMaTuDong();
                        txtMaDocGia.Focus();
                       
                    }
                    else
                        MessageBox.Show("Thông tin thẻ độc giả không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Không xác định được tên độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
            catch
            {
                MessageBox.Show("Thông tin thẻ độc giả không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                
                KhoiTaoDTO();
                if (thedocgiaBUS.KiemTra(thedocgiaDTO))
                {
                    if (thedocgiaBUS.UpDate(thedocgiaDTO))
                    {
                        MessageBox.Show("Cập nhập thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachTheDocGia.DataSource = thedocgiaBUS.Select();
                        STT();
                       

                    }
                    else
                        MessageBox.Show("Cập nhập thẻ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    txtMaDocGia.Focus();
                    TangMaTuDong();
                    dthanThe.Enabled = false;
                    dtNgayLamThe.Enabled = false;

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
            dgvDanhSachTheDocGia.DataSource = thedocgiaBUS.Select();
            STT();
            txtTuCanTim.Text = "";
        }
        void TimKiem()
        {
            
            string timKiemTheo = "";
            switch (cmbTimKiemTheo.Text.Trim())
            {
                case "Mã thẻ":
                    timKiemTheo = "MaThe";
                    break;
                case "Mã độc giả":
                    timKiemTheo = "MaDocGia";
                    break;
                case "Ngày làm thẻ":
                    timKiemTheo = "NgayLamThe";
                    break;
                case "Hạn thẻ":
                    timKiemTheo = "HanThe";
                    break;
                case "Loại thẻ":
                    timKiemTheo = "LoaiThe";
                    break;              
                default:
                    timKiemTheo = "MaThe";
                    break;
            }
            dgvDanhSachTheDocGia.DataSource = thedocgiaBUS.Search(timKiemTheo, txtTuCanTim.Text);
            STT();

        }
        private void cmbTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dgvDanhSachTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            UnLock();
            dthanThe.Enabled = true;
            dtNgayLamThe.Enabled = true;
            int row = dgvDanhSachTheDocGia.CurrentRow.Index;
            txtMaThe.Text = dgvDanhSachTheDocGia[1, row].Value.ToString();
            txtMaDocGia.Text = dgvDanhSachTheDocGia[2, row].Value.ToString();
            txtHoTen.Text = dgvDanhSachTheDocGia[3, row].Value.ToString();
            dtNgaySinh.Text = dgvDanhSachTheDocGia[4, row].Value.ToString();
            dtNgayLamThe.Text = dgvDanhSachTheDocGia[5, row].Value.ToString();
            dthanThe.Text = dgvDanhSachTheDocGia[6, row].Value.ToString();
            cmbLoaiThe.Text = dgvDanhSachTheDocGia[7, row].Value.ToString();
        }

        private void txtTuCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                TimKiem();
            }
        }

        private void cmbTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTuCanTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
