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
    public partial class frm_MuonSach : UserControl
    {
        public frm_MuonSach()
        {
           // CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            muonsachBUS = new PhieuMuon_BUS();
            muonsachDTO = new PhieuMuon_DTO();
            CTmuonsachBUS = new ChiTietMuonSach_BUS();
            CTmuonsachDTO = new ChiTietMuonSach_DTO();
            quydinh3BUS = new QuyDinh3_BUS();
            quydinh3DTO = new QuyDinh3_DTO();
            var qd = quydinh3BUS.Select().Rows[0].ItemArray;
            dtNgayMuon.Value = DateTime.Now;
            dtNgayDuKienTra.Value = dtNgayMuon.Value.AddDays(int.Parse(qd[1].ToString()));    
            lbSoLuong.Text = "0";
            KhoiTaoCmbTiemKiem();
        }

        PhieuMuon_DTO muonsachDTO;
        PhieuMuon_BUS muonsachBUS;
        ChiTietMuonSach_BUS CTmuonsachBUS;
        ChiTietMuonSach_DTO CTmuonsachDTO;
        QuyDinh3_BUS quydinh3BUS;
        QuyDinh3_DTO quydinh3DTO;


        void Lock()
        {
            txtHoTen.Enabled = false;
            txtMaPhieuMuon.Enabled = false;
            txtMaThe.Enabled = false;
            txtMaThuThu.Enabled = false;
            dtNgayMuon.Enabled = false;
            dtNgayDuKienTra.Enabled = false;         
        }

        void UnLock()
        {
            txtHoTen.Enabled = true;
            txtMaPhieuMuon.Enabled = true;
            txtMaThe.Enabled = true;
            txtMaThuThu.Enabled = true;
            dtNgayMuon.Enabled = true;
            dtNgayDuKienTra.Enabled = true;
            
        }

        void KhoiTaoDTO()
        {
            muonsachDTO.MaPhieuMuon = txtMaPhieuMuon.Text;
            muonsachDTO.MaThuThu = txtMaThuThu.Text;
            muonsachDTO.MaThe = txtMaThe.Text;
            muonsachDTO.NgayDuKienTra = dtNgayDuKienTra.Value.Date.ToString("MM/dd/yyyy");
            muonsachDTO.NgayMuon = dtNgayMuon.Value.Date.ToString("MM/dd/yyyy");
         
        }

        void Forcus()
        {
            txtHoTen.Text = "";
            txtMaPhieuMuon.Text = "";
            txtMaThe.Text = "";
            txtMaThuThu.Text = "";
            dtNgayMuon.Text = "";
            dtNgayDuKienTra.Text = "";
            lbSoLuong.Text = "0";

            while (dgvDanhSachMuon.Rows.Count > 1)
            {
                for (int i = 0; i < dgvDanhSachMuon.Rows.Count - 1; i++)
                    dgvDanhSachMuon.Rows.RemoveAt(i);
            }


        }

        void KhoiTaoCmbTiemKiem()
        {
            DataTable Loai = new DataTable();
            Loai.Columns.Add("Tìm kiếm theo:");
            Loai.Rows.Add("Mã sách");
            Loai.Rows.Add("Tên sách");
            Loai.Rows.Add("Thể loại");
            Loai.Rows.Add("Tác giả");
            Loai.Rows.Add("Tình trạng");
            cmbTimKiemTheo.DataSource = Loai;
        }

        void STT()
        {
            for (int i = 0; i < dgvDanhSachSach.Rows.Count - 1; i++)
            {
                dgvDanhSachSach.Rows[i].Cells[0].Value = i + 1;
            }
        }

        void TangMaTuDong()
        {
            string s = muonsachBUS.SelectMaPhieuMuonCuoi();
            if(s=="")
            {
                txtMaPhieuMuon.Text = "PM0000";
;            }
            else
            {
                int So = int.Parse(s.Remove(0, 2));
                if (So + 1 < 10)
                {
                    txtMaPhieuMuon.Text = "PM000" + (So + 1).ToString();
                }
                else
                {
                    if(So+1<100)
                        txtMaPhieuMuon.Text = "PM00" + (So + 1).ToString();
                    else
                    {
                        if(So+1<1000)
                            txtMaPhieuMuon.Text = "PM0" + (So + 1).ToString();
                        else
                            txtMaPhieuMuon.Text = "PM" + (So + 1).ToString();
                    }
                }
            }
            
        }

        private void txtMaPhieMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtMaThuThu.Focus();
        }

        private void txtMaThuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtMaThe.Focus();
        }

        private void cmbTiemKiemTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTuCanTim.Focus();
        }

        private void frm_MuonSach_Load(object sender, EventArgs e)
        {
            btnHuyMuon.Enabled = false;
            btnLuu.Enabled = false;
        
            dgvDanhSachSach.Enabled = false;
            txtMaThuThu.Focus();
            dgvDanhSachSach.DataSource = muonsachBUS.Select();
            STT();
            TangMaTuDong();
          
        }

        private void txtMaThe_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                
              
                 txtHoTen.Text = muonsachBUS.TimTen(txtMaThe.Text);
            
                if(txtHoTen.Text!="")
                {
                    try
                    {
                        dgvDanhSachSach.Enabled = true;
                        var qd = quydinh3BUS.Select().Rows[0].ItemArray;
                        dtNgayDuKienTra.Value = dtNgayMuon.Value.AddDays(int.Parse(qd[1].ToString()));

                        KhoiTaoDTO();
                        if (muonsachBUS.KiemTra(muonsachDTO))
                        {
                           
                            // kiem tra so sach da muon co vuot qua gioi han chua
                            int soSachDaMuon = 0;
                            string strsoSachDaMuon = muonsachBUS.SoLuongSachMuonTuTruoc(txtMaThe.Text);
                            if (strsoSachDaMuon == "")
                                soSachDaMuon = 0;
                            else
                                soSachDaMuon = int.Parse(strsoSachDaMuon);

                            if (int.Parse(qd[0].ToString()) > soSachDaMuon)
                            {
                                lbSoLuong.Text = soSachDaMuon + "";
                                DateTime hanthe = DateTime.Parse(muonsachBUS.HanThe(txtMaThe.Text));
                                DateTime now = DateTime.Now;
                                if (DateTime.Compare(now, hanthe) < 0)
                                {
                                    btnHuyMuon.Enabled = true;
                                    btnLuu.Enabled = true;
                                   
                                }
                                else
                                    MessageBox.Show("Thẻ bạn đã hết hạn! Hãy gia hạn thẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Số sách đã mượn:" + soSachDaMuon + " quyển. Bạn không đủ điều kiện để tiếp tục mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Thông tin mượn sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }catch
                    {
                        MessageBox.Show("Thông tin mượn sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                    MessageBox.Show("Mã thẻ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
                         
        void LuuChiTietMuonSach()
        {
            CTmuonsachDTO.MaPhieuMuon = txtMaPhieuMuon.Text;
          
            int kt = 0;
            for ( int i= 0; i < dgvDanhSachMuon.Rows.Count - 1; i++)
            {
                CTmuonsachDTO.ChuThich = dgvDanhSachMuon.Rows[i].Cells["GhiChu"].FormattedValue.ToString();

                CTmuonsachDTO.MaSach = dgvDanhSachMuon.Rows[i].Cells["MaSach"].FormattedValue.ToString();
                if(!CTmuonsachBUS.Insert(CTmuonsachDTO) || !CTmuonsachBUS.UpdateTTSach(CTmuonsachDTO))
                {
                    kt = 1;
                    MessageBox.Show("Mượn sách không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }           
            }
            if (kt == 0)
            {
                MessageBox.Show("Mượn sách thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachSach.DataSource = muonsachBUS.Select();
                STT();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                KhoiTaoDTO();

                if (muonsachBUS.Insert(muonsachDTO))
                {
                    LuuChiTietMuonSach();                                                          
                }
                else
                {
                    MessageBox.Show("Thông tin mượn sách không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Forcus();
                dgvDanhSachSach.Enabled = false;
                TangMaTuDong();
                txtMaThuThu.Focus();
            

            }catch
            {
                MessageBox.Show("Thông tin mượn sách không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnHuyMuon_Click(object sender, EventArgs e)
        {
            try
            {
                Forcus();
                TangMaTuDong();
                dgvDanhSachSach.Enabled = false;
                txtMaThuThu.Focus();
            }
            catch
            {
                MessageBox.Show("Tác vụ không được thực hiện!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                            
        }
        void TimKiem()
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
                default:
                    timKiemTheo = "MaSach";
                    break;
            }
            dgvDanhSachSach.DataSource = muonsachBUS.TimKiem(timKiemTheo, txtTuCanTim.Text);
            STT();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dgvDanhSachSach.DataSource = muonsachBUS.Select();
            STT();
            txtTuCanTim.Text = "";

        }

        private void txtTuCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TimKiem();
            }
        }

        private void dgvDanhSachSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var qd = quydinh3BUS.Select().Rows[0].ItemArray;

                if (int.Parse(lbSoLuong.Text) == int.Parse(qd[0].ToString()))

                    MessageBox.Show("Số sách bạn mượn vượt qua giới hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int rowSach = dgvDanhSachSach.CurrentRow.Index;
                    string t1 = "Y";
                    string t2 = dgvDanhSachSach[5, rowSach].Value.ToString().Trim();
                    if (t1 == t2)
                    {
                        MessageBox.Show("Sách này không còn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int kt = 0;
                        for (int i = 0; i < dgvDanhSachMuon.Rows.Count - 1; i++)
                        {
                            CTmuonsachDTO.MaSach = dgvDanhSachMuon.Rows[i].Cells["MaSach"].Value.ToString();
                            if (CTmuonsachDTO.MaSach == dgvDanhSachSach.Rows[dgvDanhSachSach.CurrentRow.Index].Cells["MaSachs"].Value.ToString())
                            {
                                MessageBox.Show("Sách này bạn đã mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                kt = 1;
                                break;
                            }
                        }
                        if (kt == 0)
                        {
                            int row = dgvDanhSachMuon.Rows.Add();
                            int curRow = dgvDanhSachSach.CurrentRow.Index;

                            dgvDanhSachMuon[0, row].Value = dgvDanhSachSach.Rows[curRow].Cells["MaSachs"].Value;

                            dgvDanhSachMuon[1, row].Value = dgvDanhSachSach.Rows[curRow].Cells["TenSachs"].Value;

                            dgvDanhSachMuon[2, row].Value = dgvDanhSachSach.Rows[curRow].Cells["TheLoais"].Value;

                            dgvDanhSachMuon[3, row].Value = dgvDanhSachSach.Rows[curRow].Cells["TacGias"].Value;

                            dgvDanhSachMuon[4, row].Value = dgvDanhSachSach.Rows[curRow].Cells["GhiChus"].Value;

                            lbSoLuong.Text = (int.Parse(lbSoLuong.Text) + 1).ToString();
                        }

                    }

                }
            }
            catch
            {
                MessageBox.Show("Tác vụ không được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgvDanhSachMuon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int row = dgvDanhSachMuon.CurrentRow.Index;            
                dgvDanhSachMuon.Rows.RemoveAt(row);
                lbSoLuong.Text = (int.Parse(lbSoLuong.Text) - 1).ToString();
            }
            catch
            {
                MessageBox.Show("Tác vụ không được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
