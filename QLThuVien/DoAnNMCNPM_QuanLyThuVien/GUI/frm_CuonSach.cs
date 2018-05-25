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
    public partial class frm_CuonSach : UserControl
    {
        public frm_CuonSach()
        {
            InitializeComponent();
            cuonSachBUS = new CuonSach_BUS();
            cuonSachDTO = new CuonSach_DTO();
            KhoiTaoCmbTimKiem();
            KhoiTaoCmbMaDauSach();
        }

        CuonSach_BUS cuonSachBUS;
        CuonSach_DTO cuonSachDTO;

        void Forcus()
        {
            txtLoai.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = "";
            txtGhiChu.Text = "";
            txtLoai.Text = "";         
            dtNgayNhap.Text = DateTime.Now.ToShortDateString();
            txtGia.Text = "";

        }

        void Lock()
        {
            txtMaSach.Enabled = false;
            cmbMaDauSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtNXB.Enabled = false;
            txtNamXB.Enabled = false;
            txtGhiChu.Enabled = false;
            txtGhiChu.Enabled = false;
            txtLoai.Enabled = false;
            txtTinhTrang.Enabled = false;
            dtNgayNhap.Enabled = false;
            txtGia.Enabled = false;
        }

        void Unlock()
        {
           
            cmbMaDauSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtNXB.Enabled = true;
            txtNamXB.Enabled = true;
            txtGhiChu.Enabled = true;
            txtGhiChu.Enabled = true;
            txtLoai.Enabled = true;
            txtTinhTrang.Enabled = true;
            dtNgayNhap.Enabled = true;
            txtGia.Enabled = true;

        }

       
        void KhoiTaoCmbTimKiem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Tìm kiếm theo");
            table.Rows.Add("Mã sách");
            table.Rows.Add("Tên sách");
            table.Rows.Add("Tác giả");
            table.Rows.Add("Thể loại");
            table.Rows.Add("Tình trạng");
            table.Rows.Add("Ngày nhập");
            cmbTimKiemTheo.DataSource = table;
        }

        void  KhoiTaoCmbMaDauSach()
        {
            DataTable table = cuonSachBUS.SelectListMaDauSach();
            cmbMaDauSach.DataSource = table;
           
        }
        void KhoiTaoCuonSachDTO()
        {
            cuonSachDTO.MaSach = txtMaSach.Text.Trim();
            cuonSachDTO.MaDauSach = cmbMaDauSach.Text.Trim();
            cuonSachDTO.NgayNhap = dtNgayNhap.Text.Trim();
            cuonSachDTO.TinhTrang = txtTinhTrang.Text.Trim();
            cuonSachDTO.ChuThich = txtGhiChu.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Unlock();
            Forcus();
            TangMaTangTuDong();
            cmbMaDauSach.Focus();

        }

        void TangMaTangTuDong()
        {
            int count = dgvThongTinSach.Rows.Count;
            if (count > 2)
            {
                int Chuoi = 0;
                string strChuoi = "";
                strChuoi = Convert.ToString(dgvThongTinSach.Rows[count - 2].Cells[1].Value);
                Chuoi = Convert.ToInt32(strChuoi.Remove(0, 2));

                if (Chuoi + 1 < 10)
                    txtMaSach.Text = "MS000" + (Chuoi + 1).ToString();
                else
                {
                    if (Chuoi + 1 < 100)
                        txtMaSach.Text = "MS00" + (Chuoi + 1).ToString();
                    else
                    {
                        if (Chuoi + 1 < 1000)
                            txtMaSach.Text = "MS0" + (Chuoi + 1).ToString();
                        else
                            txtMaSach.Text = "MS" + (Chuoi + 1).ToString();
                    }
                }
            }
            else
            {
                txtMaSach.Text = "MS0000";
            }

        }

        void STT()
        {
            for (int i = 0; i < dgvThongTinSach.Rows.Count - 1; i++)
            {
                dgvThongTinSach.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void txtMaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                cmbMaDauSach.Focus();
        }

   
        private void dtNgayNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtGia.Focus();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtGhiChu.Focus();
        }

        private void cmbTimKiemTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTuCanTim.Focus();
        }


      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoCuonSachDTO();
                if (dtNgayNhap.Value <= DateTime.Now)
                {
                    if (cuonSachBUS.KiemTra(cuonSachDTO) && txtTenSach.Text !="")
                    {
                        if (cuonSachBUS.Insert(cuonSachDTO))
                        {
                            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvThongTinSach.DataSource = cuonSachBUS.Select();
                            STT();
                        }
                        else
                            MessageBox.Show("Thêm sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Forcus();
                        TangMaTangTuDong();
                        cmbMaDauSach.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin chi tiết sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Ngày nhập phải nhỏ hơn hoặc bằng ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu nhập vào không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void frm_CuonSach_Load(object sender, EventArgs e)
        {
            txtMaSach.Focus();
            txtTinhTrang.Text= "N";
            dgvThongTinSach.DataSource = cuonSachBUS.Select();
            STT();
            Lock();
            cmbMaDauSach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoCuonSachDTO();
                if (cuonSachBUS.KiemTra(cuonSachDTO) )
                {
                    if (cuonSachBUS.Delete(cuonSachDTO))
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvThongTinSach.DataSource = cuonSachBUS.Select();
                        STT();
                    }
                    else
                        MessageBox.Show("Xóa sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    TangMaTangTuDong();
                    cmbMaDauSach.Focus();
                    
                }
                else
                {
                    MessageBox.Show("Thông tin sách cần xóa không không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin sách cần xóa không không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                    
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoCuonSachDTO();
                if (cuonSachBUS.KiemTra(cuonSachDTO))
                {
                    if (cuonSachBUS.Update(cuonSachDTO))
                    {
                        MessageBox.Show("Cập nhập sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvThongTinSach.DataSource = cuonSachBUS.Select();
                        STT();
                    }
                    else
                        MessageBox.Show("Cập nhập sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forcus();
                    TangMaTangTuDong();
                    cmbMaDauSach.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin cập nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin cập nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void dgvThongTinSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Unlock();      
            int row = dgvThongTinSach.CurrentRow.Index;
           txtMaSach.Text = dgvThongTinSach[1, row].Value.ToString();
            txtTenSach.Text = dgvThongTinSach[2, row].Value.ToString();
            txtTacGia.Text = dgvThongTinSach[3, row].Value.ToString();
            txtLoai.Text = dgvThongTinSach[4, row].Value.ToString();
            dtNgayNhap.Text = dgvThongTinSach[5, row].Value.ToString();
            txtTinhTrang.Text = dgvThongTinSach[6, row].Value.ToString();
            txtGhiChu.Text = dgvThongTinSach[7, row].Value.ToString();
            DataTable dauSachTable = new DataTable();
            dauSachTable = cuonSachBUS.SelectMaDauSach(txtMaSach.Text);
            if (dauSachTable == null)
            {
                MessageBox.Show("lỗi hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dauSach = dauSachTable.Rows[0].ItemArray;
                cmbMaDauSach.Text = dauSach[0].ToString();
                DataTable cTTable = new DataTable();
            
                cTTable = cuonSachBUS.SelectCTClick(cmbMaDauSach.Text);
                if (cTTable==null)
                {
                    MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var cT = cTTable.Rows[0].ItemArray;                
                    txtNamXB.Text = cT[0].ToString();
                    txtNXB.Text = cT[1].ToString();
                    txtGia.Text = cT[2].ToString();
                }

            }

        }


        void  TimKiem()
        {
                    
            string timKiemTheo = "";
            switch (cmbTimKiemTheo.Text.Trim())
            {
                case "Mã sách":
                    timKiemTheo = "MaSach";
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
                case "Tình trạng":
                    timKiemTheo = "TinhTrang";
                    break;
                case "Ngày nhập":
                    timKiemTheo = "NgayNhap";
                    break;
                default:
                    timKiemTheo = "MaSach";
                    break;

            }

            dgvThongTinSach.DataSource = cuonSachBUS.Search(timKiemTheo, txtTuCanTim.Text);
            STT();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
     
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dgvThongTinSach.DataSource = cuonSachBUS.Select();
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

    
        private void cmbMaDauSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    DataTable cTTable = new DataTable();

                    cTTable = cuonSachBUS.SelectCTEnter(cmbMaDauSach.Text);

                    var cT = cTTable.Rows[0].ItemArray;
                    txtTenSach.Text = cT[0].ToString();
                    txtTacGia.Text = cT[1].ToString();
                    txtLoai.Text = cT[2].ToString();
                    txtNamXB.Text = cT[3].ToString();
                    txtNXB.Text = cT[4].ToString();
                    txtGia.Text = cT[5].ToString();
                    txtGhiChu.Focus();
                }
                catch
                {
                    MessageBox.Show("Mã đầu sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

       
    }
}
