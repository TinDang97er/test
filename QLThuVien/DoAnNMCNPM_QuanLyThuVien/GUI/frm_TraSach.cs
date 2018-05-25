using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.BUS;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_TraSach : UserControl
    {
        public frm_TraSach()
        {
            InitializeComponent();
            phieuPhatDTO = new PhieuPhat_DTO();
            phieuPhatBUS = new PhieuPhat_BUS();
            phieuTraBUS = new PhieuTra_BUS();
            phieuTraDTO = new PhieuTra_DTO();
            ctTraSachBUS = new ChiTietTraSach_BUS();
            ctTraSachDTO = new ChiTietTraSach_DTO();

        }

        PhieuPhat_DTO phieuPhatDTO;
        PhieuPhat_BUS phieuPhatBUS;
        PhieuTra_DTO phieuTraDTO;
        PhieuTra_BUS phieuTraBUS;
        ChiTietTraSach_BUS ctTraSachBUS;
        ChiTietTraSach_DTO ctTraSachDTO;
        int tongNgayTraTre = 0;
   
        void ForCus()
        {
            txtMaPhieuTra.Text = "";
            txtMaThe.Text = "";
            txtMaThuThu.Text = "";
            txtTen.Text = "";
            lbTongNgay.Text = "0";
            while (dgvThongTinTra.Rows.Count > 1)
            {
                for (int i = 0; i < dgvThongTinTra.Rows.Count - 1; i++)
                    dgvThongTinTra.Rows.RemoveAt(i);
            }

            while (dgvThongTinSachMuon.Rows.Count > 1)
            {
                for (int i = 0; i < dgvThongTinSachMuon.Rows.Count - 1; i++)
                    dgvThongTinSachMuon.Rows.RemoveAt(i);
            }
        }

        public void KhoiTaoTraSachDTO()
        {
            phieuTraDTO.MaPhieuTra = txtMaPhieuTra.Text;
            phieuTraDTO.MaThe = txtMaThe.Text;
            phieuTraDTO.MaThuThu = txtMaThuThu.Text;
            phieuTraDTO.NgayTra = dtNgayTra.Value.ToShortDateString();          
        }

        void  TangMaTuDong()
        {
            string s = phieuTraBUS.SelectMaPhieuTraCuoi();
            if (s == "")
            {
                txtMaPhieuTra.Text = "PT0000";
               
            }
            else
            {
                int So = int.Parse(s.Remove(0, 2));
                if (So + 1 < 10)
                {
                    txtMaPhieuTra.Text = "PT000" + (So + 1).ToString();
                }
                else
                {
                    if (So + 1 < 100)
                        txtMaPhieuTra.Text = "PT00" + (So + 1).ToString();
                    else
                    {
                        if (So + 1 < 1000)
                            txtMaPhieuTra.Text = "PT0" + (So + 1).ToString();
                        else
                            txtMaPhieuTra.Text = "PT" + (So + 1).ToString();
                    }
                }
            }
        }

        private void txtMaPhieuTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtMaThuThu.Focus();
        }

        private void txtMaThuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtMaThe.Focus();
        }

        private void txtMaDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable table = phieuTraBUS.SelectTen(txtMaThe.Text);

                try
                {
                    var x = table.Rows[0].ItemArray;
                    txtTen.Text = x[0].ToString();
                    KhoiTaoTraSachDTO();
                    if (phieuTraBUS.KiemTra(phieuTraDTO))
                    {                      
                        dgvThongTinSachMuon.DataSource = phieuTraBUS.SelectCTMuon(txtMaThe.Text);
                    }
                    else
                        MessageBox.Show("Thông tin trả sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("Mã thẻ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frm_TraSach_Load(object sender, EventArgs e)
        {
          
            dtNgayTra.Text = DateTime.Now.ToShortDateString();
            lbTongNgay.Text = "0";        
            TangMaTuDong();
            txtMaThuThu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           phieuPhatDTO.MaPhieuTra = txtMaPhieuTra.Text;
            try
            {
                KhoiTaoTraSachDTO();

                if (phieuTraBUS.KiemTra(phieuTraDTO))
                {
                    if (phieuTraBUS.Insert(phieuTraDTO))
                    {
                        if (tongNgayTraTre!= 0)
                        {
                            frm_ThanhToan thanhToan = new frm_ThanhToan(phieuPhatDTO, tongNgayTraTre);
                            thanhToan.ShowDialog();
                        }
                        LuuCTTraSach();                       
                    }
                    else
                    {                      
                        MessageBox.Show("Trả sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin Trả sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ForCus();
                TangMaTuDong();
                txtMaThuThu.Focus();

            }
            catch
            {
                MessageBox.Show("Thông tin Trả sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnHuyTra_Click(object sender, EventArgs e)
        {
                                                     
               ForCus();
                TangMaTuDong();
                txtMaThuThu.Focus();
        }

        void LuuCTTraSach()
        {

            ctTraSachDTO.MaPhieuTra = txtMaPhieuTra.Text;
            int kt = 0;
            for (int i = 0; i < dgvThongTinTra.Rows.Count - 1; i++)
            {
                ctTraSachDTO.MaPhieuMuon = dgvThongTinTra.Rows[i].Cells["MaPhieuMuont"].Value.ToString();
                ctTraSachDTO.MaSach = dgvThongTinTra.Rows[i].Cells["MaSacht"].Value.ToString();
                ctTraSachDTO.SoNgayTraMuon = int.Parse(dgvThongTinTra.Rows[i].Cells["SoNgayTraMuon"].Value.ToString());
                ctTraSachDTO.ChuThich = dgvThongTinTra.Rows[i].Cells["TinhTrangTra"].Value.ToString();

                if (ctTraSachBUS.KiemTra(ctTraSachDTO))
                {
                    if (!ctTraSachBUS.Insert(ctTraSachDTO) || !ctTraSachBUS.UpdateTTSach(ctTraSachDTO))
                    {
                        kt = 1;
                        MessageBox.Show("Trả sách không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                else
                {
                    kt = 1;
                    MessageBox.Show("Thông tin chưa đầy đủ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            if (kt == 0)
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
            }
        }
    
        private void dgvThongTinTra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvThongTinTra.CurrentRow.Index;
                string maPhiieuMuon = dgvThongTinTra[0, row].Value.ToString().Trim();
                string maSach = dgvThongTinTra[1, row].Value.ToString().Trim();
                tongNgayTraTre -= int.Parse(dgvThongTinTra.Rows[row].Cells["SoNgayTraMuon"].Value.ToString());
                lbTongNgay.Text = tongNgayTraTre.ToString();
                dgvThongTinTra.Rows.RemoveAt(row);
                for (int i = 0; i< dgvThongTinSachMuon.Rows.Count -1; i++)
                {
                    if(maPhiieuMuon == dgvThongTinSachMuon[0,i].Value.ToString()&& maSach == dgvThongTinSachMuon[1, i].Value.ToString())
                    {
                        dgvThongTinSachMuon.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        break;
                    }
                }
            }
            catch
            {     
              MessageBox.Show("Tác vụ không được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgvThongTinSachMuon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
              
                int curRow = dgvThongTinSachMuon.CurrentRow.Index;            
                if (dgvThongTinSachMuon.Rows[curRow].DefaultCellStyle.BackColor != Color.SkyBlue)
                {
                    int addRow = dgvThongTinTra.Rows.Add();
                    dgvThongTinSachMuon.Rows[curRow].DefaultCellStyle.BackColor = Color.SkyBlue;
                    dgvThongTinTra.Rows[addRow].Cells["MaPhieuMuont"].Value = dgvThongTinSachMuon.Rows[curRow].Cells["MaPhieuMuon"].Value;
                    dgvThongTinTra.Rows[addRow].Cells["MaSacht"].Value = dgvThongTinSachMuon.Rows[curRow].Cells["MaSach"].Value;
                    dgvThongTinTra.Rows[addRow].Cells["TenSacht"].Value = dgvThongTinSachMuon.Rows[curRow].Cells["TenSach"].Value;
                    dgvThongTinTra.Rows[addRow].Cells["TheLoait"].Value = dgvThongTinSachMuon.Rows[curRow].Cells["TheLoai"].Value;
                    dgvThongTinTra.Rows[addRow].Cells["TinhTrangTra"].Value = dgvThongTinSachMuon.Rows[curRow].Cells["TinhTrangMuon"].Value;
                    dgvThongTinTra.Rows[addRow].Cells["TacGiat"].Value = dgvThongTinSachMuon.Rows[curRow].Cells["TacGia"].Value;

                    DateTime NgayDuKienTra = DateTime.Parse(dgvThongTinSachMuon.Rows[curRow].Cells["NgayDuKienTra"].Value.ToString());
                    if (NgayDuKienTra > DateTime.Now)
                    {
                        dgvThongTinTra.Rows[addRow].Cells["SoNgayTraMuon"].Value = "0";
                    }
                    else
                    {
                        TimeSpan d = DateTime.Now.Subtract(NgayDuKienTra);
                        var arr = d.ToString().Split('.');
                        int day = int.Parse(arr[0]);

                        dgvThongTinTra.Rows[addRow].Cells["SoNgayTraMuon"].Value = day.ToString();
                        tongNgayTraTre += int.Parse(day.ToString());
                        lbTongNgay.Text = tongNgayTraTre.ToString();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Sách này đã nằm trong danh sách trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch
            {
                MessageBox.Show("Tác vụ không được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
