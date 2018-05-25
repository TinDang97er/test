using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.GUI;
using DoAnNMCNPM_QuanLyThuVien.BUS;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_QuyDinh : UserControl
    {
        public frm_QuyDinh()
        {
            InitializeComponent();
            qd1BUS = new QuyDinh1_BUS();
            qd2BUS = new QuyDinh2_BUS();
            qd3BUS = new QuyDinh3_BUS();
            this.Load += Frm_QuyDinh_Load;
        }
        QuyDinh1_BUS qd1BUS;
        QuyDinh2_BUS qd2BUS;
        QuyDinh3_BUS qd3BUS;
        private void Frm_QuyDinh_Load(object sender, EventArgs e)
        {
            showQuyDinh();
          
        }
        void showQuyDinh()
        {
            try
            {
                DataTable tableQd1 = new DataTable();
                DataTable tableQd2 = new DataTable();
                DataTable tableQd3 = new DataTable();
                tableQd1 = qd1BUS.Select();
                tableQd2 = qd2BUS.Select();
                tableQd3 = qd3BUS.Select();
                var t1 = tableQd1.Rows[0].ItemArray;
                var t2 = tableQd2.Rows[0].ItemArray;
                var t3 = tableQd3.Rows[0].ItemArray;

                string qd = @"- QD1: Có 2 loại độc giả(A, B),tuổi độc giả  từ " + t1[0].ToString() + " đến " + t1[1].ToString() + " ,"
                              + "thẻ có giá trị trong " + t1[2].ToString() + " tháng.                                                                                   " +
                               " - QD2: Có " + t2[0].ToString() + " thể loại.  Có 100 tác giả,                                                                           " +
                               "    chỉ nhận sách trong vòng " + t2[1].ToString() + " năm.                                                                               " +
                               " - QD3: Chỉ cho mượn với thẻ còn hạn, Không cho mượn với thẻ quá hạn và sách không có người mượn,                                       " +
                                   " Mỗi độc giả mượn tối đa " + t3[0].ToString() + " quyển  trong " + t3[1].ToString() + " ngày.                                       " +
                                "- QD4: Mỗi ngày trả trễ phạt 1.000 đồng/ngày.                                                                                          " +
                               " - QD5: Số tiền thu không được vượt quá số tiền độc giả đang nợ.";
                rtxtQuyDinh.Text = qd;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQuyDinh1_Click(object sender, EventArgs e)
        {
            Frm_CapNhapQD1 qd1 = new Frm_CapNhapQD1();
            qd1.ShowDialog();
            showQuyDinh();
           
        }

        private void btnQuyDinh2_Click(object sender, EventArgs e)
        {
            frm_CapNhapQD2 qd2 = new frm_CapNhapQD2();
            qd2.ShowDialog();
            showQuyDinh();
           
        }

        private void btnQuyDinh3_Click(object sender, EventArgs e)
        {
            Frm_CapNhapQD3 qd3 = new Frm_CapNhapQD3();
            qd3.ShowDialog();
            showQuyDinh();
          
        }
    }
}
