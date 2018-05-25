using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;
using System.Windows.Forms;
namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
   public class PhieuPhat_BUS
    {
        public PhieuPhat_BUS()
        {
            PhieuPhat = new PhieuPhat_DAL();
        }

        PhieuPhat_DAL PhieuPhat;

        public bool KiemTra(PhieuPhat_DTO p)
        {
            if ( p.MaPhieuTra == "" || p.TongNo == 0)
                return false;
            else
                return true;
        }

        public DataTable Select()
        {
            return PhieuPhat.Select();
        }

        public DataTable Search(string loai, string tuCanTim)
        {
            return PhieuPhat.Search(loai, tuCanTim);
        }

        public bool Insert(PhieuPhat_DTO p)
        {
            return PhieuPhat.Insert(p);
        }
        
    }
}
