using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNMCNPM_QuanLyThuVien
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            main = new Frm_Main();
        }

        Frm_Main main;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" )        
                MessageBox.Show("Thông tin cung cấp chưa đầy đủ!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (chkXacNhan.Checked == false)
                    MessageBox.Show("Bạn chưa xác nhận đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtTenDangNhap.Text == "Amin" && txtMatKhau.Text == "1234")
                    {
                        main.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng!");

                }
            }
          
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtMatKhau.Focus();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}
