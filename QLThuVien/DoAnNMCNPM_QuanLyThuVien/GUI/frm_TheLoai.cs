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

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_TheLoai : Form
    {
        public frm_TheLoai(int _SoTheLoai)
        {
            InitializeComponent();
            soTheLoai = _SoTheLoai;
            theLoaiBUS = new TheLoai_BUS();
            theLoaiDTO = new TheLoai_DTO();
            listTheLoai = new List<string>();
            kiemtra = true;
            xacNhanCapNhap = false;

        }
        public static bool kiemtra;
        public static bool xacNhanCapNhap;
        int soTheLoai;
        TheLoai_BUS theLoaiBUS;
        TheLoai_DTO theLoaiDTO;
        List<string> listTheLoai;

        private void frm_TheLoai_Load(object sender, EventArgs e)
        {
            txtTenTheLoai.Focus();
            btnLuu.Enabled = false;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(soTheLoai>0)
            {
                if (txtTenTheLoai.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    listTheLoai.Add(txtTenTheLoai.Text.ToString());
                    txtTenTheLoai.Text = "";
                    soTheLoai--;
                    txtTenTheLoai.Focus();
                }               
            }
            else
            {
                btnLuu.Enabled = true;
                txtTenTheLoai.Text = "";
                MessageBox.Show("Bạn đã nhập đủ số lượng tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
              
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(theLoaiBUS.Delete())
            {
                int kt = 1;
                foreach(string item in listTheLoai)
                {
                    theLoaiDTO.TenTheLoai = item;
                    if (!theLoaiBUS.Insert(theLoaiDTO) || !theLoaiBUS.KiemTra(theLoaiDTO))
                    {
                        kiemtra = false;                   
                        kt = 0;
                        MessageBox.Show("Thêm tên thể loại không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (kt == 1)
                {
                    MessageBox.Show("Thêm tên thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kiemtra = true;
                    xacNhanCapNhap = true;
                }
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
