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
    public partial class frm_DauSach : UserControl
    {
        public frm_DauSach()
        {
            InitializeComponent();
            dausachBUS = new DauSach_BUS();
            dausachDTO = new DauSach_DTO();
            theLoai = new TheLoai_BUS();
            qd2 = new QuyDinh2_BUS();
            KhoiTaoCmdLoai();
            KhoiTaoCmbTiemKiem();
            DataTable table = new DataTable();
            table = qd2.Select();
            var i = table.Rows[0].ItemArray;
            HanNhanSach = int.Parse(i[1].ToString());
        }

        DauSach_DTO dausachDTO;
        DauSach_BUS dausachBUS;
        TheLoai_BUS theLoai;
        QuyDinh2_BUS qd2;
        int HanNhanSach;

        void Lock()
        {
            txtMaDauSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            cmbLoai.Enabled = false;
            txtNamXB.Enabled = false;
            txtNXB.Enabled = false;
            txtGia.Enabled = false;
            txtSoLuongSach.Enabled = false;
        }
        void UnLock()
        {
           
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            cmbLoai.Enabled = true;
            txtNamXB.Enabled = true;
            txtNXB.Enabled = true;
            txtGia.Enabled = true;
            txtSoLuongSach.Enabled = true;
        }

        void STT()
        {
            for (int i = 0; i < dgvDanhSachDauSach.Rows.Count - 1; i++)
            {
                dgvDanhSachDauSach.Rows[i].Cells[0].Value = i + 1;
            }
        }

        void Forcus()
        {
            txtMaDauSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            cmbLoai.Text = "";
            txtNamXB.Text = "";
            txtNXB.Text = "";
            txtGia.Text = "";
            txtSoLuongSach.Text = "0";
           
        }

        void KhoiTaoCmdLoai()
        {
            cmbLoai.DataSource = theLoai.Select();
        }

        void KhoiTaoCmbTiemKiem()
        {
            DataTable Loai = new DataTable();
            Loai.Columns.Add("Tìm kiếm theo:");
            Loai.Rows.Add("Mã đầu sách");
            Loai.Rows.Add("Tên sách");
            Loai.Rows.Add("Tác giả");
            Loai.Rows.Add("Thể loại");
            Loai.Rows.Add("Năm sản xuất");
            Loai.Rows.Add("Nhà sản xuất");
            cmbTimKiemTheo.DataSource = Loai;

        }
        void KhoiTaoDTO()
        {
            dausachDTO.MaDauSach = txtMaDauSach.Text.Trim();
            dausachDTO.TenDauSach = txtTenSach.Text.Trim();
            dausachDTO.TenTheLoai = cmbLoai.Text.Trim();
            dausachDTO.TacGia = txtTacGia.Text.Trim();
            dausachDTO.Gia = float.Parse(txtGia.Text.Trim());
            dausachDTO.NamSanXuat = int.Parse(txtNamXB.Text.Trim());
            dausachDTO.NhaSanXuat = txtNXB.Text.Trim();
            dausachDTO.SoLuong = int.Parse(txtSoLuongSach.Text.Trim());

        }

        void TaoMaTangTuDong()
        {
            int count = dgvDanhSachDauSach.Rows.Count;
            if (count > 2)
            {
                int Chuoi = 0;
                string strChuoi = "";
                strChuoi = Convert.ToString(dgvDanhSachDauSach.Rows[count - 2].Cells[1].Value);
                Chuoi = Convert.ToInt32(strChuoi.Remove(0, 3));

                if (Chuoi + 1 < 10)
                    txtMaDauSach.Text = "MDS00" + (Chuoi + 1).ToString();
                else
                {
                    if (Chuoi + 1 < 100)
                        txtMaDauSach.Text = "MDS0" + (Chuoi + 1).ToString();
                    else
                    {
                        if (Chuoi + 1 < 1000)
                            txtMaDauSach.Text = "MDS" + (Chuoi + 1).ToString();

                    }
                }
            }
            else
            {
                txtMaDauSach.Text = "MDS000";
            }

        }
        private void txtMaDauSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTenSach.Focus();
        }

        private void txtTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTacGia.Focus();
        }

        private void txtTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                cmbLoai.Focus();
        }

        private void cmbLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtNamXB.Focus();
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtNXB.Focus();
        }

        private void cmbTimKiemTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTuCanTim.Focus();
        }

        private void frm_DauSach_Load(object sender, EventArgs e)
        {
            dgvDanhSachDauSach.DataSource = dausachBUS.Select();
            STT();
            Lock();         
            txtSoLuongSach.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLock();
            Forcus();         
            TaoMaTangTuDong();
            txtTenSach.Focus();
           
        }

     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (int.Parse(txtNamXB.Text) <= DateTime.Now.Year)
                {
                    int tg = DateTime.Now.Year - int.Parse(txtNamXB.Text);
                    if (tg <= HanNhanSach)
                    {
                        if (dausachBUS.KiemTra(dausachDTO))
                        {
                            if (dausachBUS.Insert(dausachDTO))
                            {
                                MessageBox.Show("Thêm đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDanhSachDauSach.DataSource = dausachBUS.Select();
                                STT();
                            }
                            else
                                MessageBox.Show("Thêm đầu sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Forcus();
                            TaoMaTangTuDong();
                            txtTenSach.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin đầu sách không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Chỉ nhận sách trong vòng " + HanNhanSach + " năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                    MessageBox.Show("Năm xuất bản phải nhỏ hơn hoặc bằng năm hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch
            {
                MessageBox.Show("Thông tin sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (dausachBUS.KiemTra(dausachDTO))
                {
                    if (dausachBUS.Update(dausachDTO))
                    {
                        MessageBox.Show("Cập nhập sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachDauSach.DataSource = dausachBUS.Select();
                        STT();                       
                    }
                    else
                        MessageBox.Show("cập nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                    Forcus();
                    TaoMaTangTuDong();
                    txtTenSach.Focus();

                }
                else
                    MessageBox.Show("Thông tin cập nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Thông tin cập nhập không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();
                if (dausachBUS.KiemTra(dausachDTO))
                {
                    if (dausachBUS.Delete(dausachDTO))
                    {
                        MessageBox.Show("Xóa đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachDauSach.DataSource = dausachBUS.Select();
                        STT();                     
                    }
                    else
                        MessageBox.Show("Xóa đầu sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    TaoMaTangTuDong();
                    txtTenSach.Focus();
                }
                else
                    MessageBox.Show("Thông tin đầu sách cần xóa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Thông tin đầu sách cần xóa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void dgvThongTinDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UnLock();
            txtMaDauSach.IsReadOnly = true;
            int row = dgvDanhSachDauSach.CurrentRow.Index;
            txtMaDauSach.Text = dgvDanhSachDauSach[1, row].Value.ToString();
            txtTenSach.Text = dgvDanhSachDauSach[2, row].Value.ToString();
            cmbLoai.Text = dgvDanhSachDauSach[4, row].Value.ToString();
            txtTacGia.Text = dgvDanhSachDauSach[3, row].Value.ToString();
            txtGia.Text = dgvDanhSachDauSach[7, row].Value.ToString();
            txtNamXB.Text = dgvDanhSachDauSach[5, row].Value.ToString();
            txtNXB.Text = dgvDanhSachDauSach[6, row].Value.ToString();
            txtSoLuongSach.Text = dgvDanhSachDauSach[8, row].Value.ToString();
        }

        void TimKiem()
        {
       
            string timKiemTheo = "";
            switch (cmbTimKiemTheo.Text.Trim())
            {
                case "Mã đầu sách":
                    timKiemTheo = "MaDauSach";
                    break;
                case "Tên sách":
                    timKiemTheo = "TenDauSach";
                    break;
                case "Tác giả":
                    timKiemTheo = "TacGia";
                    break;
                case "Thể loại":
                    timKiemTheo = "TenTheLoai";
                    break;
                case "Năm sản xuất":
                    timKiemTheo = "NamSanXuat";
                    break;
                case "Nhà sản xuất":
                    timKiemTheo = "NhaSanXuat";
                    break;
                default:
                    timKiemTheo = "MaDauSach";
                    break;
            }
            dgvDanhSachDauSach.DataSource = dausachBUS.Search(timKiemTheo, txtTuCanTim.Text);
            STT();
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            dgvDanhSachDauSach.DataSource = dausachBUS.Select();
            txtTuCanTim.Text = "";
            STT();
        }

        private void txtTuCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                TimKiem();
            }
        }

        private void txtNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                txtGia.Focus();
            }
        }

        private void txtSoLuongSach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
