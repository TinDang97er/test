using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.BUS;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Windows.Forms;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_ThanhToan : Form
    {
        public frm_ThanhToan(PhieuPhat_DTO phieuphat,int soNgayTraMuon)
        {

            InitializeComponent();
            phieuPhatBUS = new PhieuPhat_BUS();
            phieuPhatDTO = phieuphat;
            phieuPhatDTO.TongNo = soNgayTraMuon * 1000;
      

        }

        PhieuPhat_DTO phieuPhatDTO;
        PhieuPhat_BUS phieuPhatBUS;

        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {

            lbMaPhieuTra.Text = phieuPhatDTO.MaPhieuTra;
            lbTongNo.Text = phieuPhatDTO.TongNo.ToString();
          

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           
            if (txtTongTienThu.Text.Trim() == "")
                MessageBox.Show("Bạn chưa nhập tổng tiền thu!");
            else
            {
                if (!phieuPhatBUS.Insert(phieuPhatDTO))
                    MessageBox.Show("Thanh toán không thành công!");
                else
                {
                    
                    MessageBox.Show("Thanh toán thành công!");
                    this.Close();
                }

                lbMaPhieuTra.Text = "";
                lbTongNo.Text = "";
                                
            }

        }

        private void txtTongTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(int.Parse(txtTongTienThu.Text)< int.Parse(lbTongNo.Text))
                {
                    MessageBox.Show("Số tiền thu phải lớn hơn hoặc bằng tổng tiền nợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lbTienTraLai.Text = ((float.Parse(txtTongTienThu.Text)) - (float.Parse(lbTongNo.Text))).ToString();
                }
               
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
