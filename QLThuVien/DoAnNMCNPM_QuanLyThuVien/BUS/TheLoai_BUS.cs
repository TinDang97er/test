using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.DAL;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Data;
namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
    public class TheLoai_BUS
    {
        public TheLoai_BUS()
        {
            theloai = new TheLoai_DAL();
        }

        TheLoai_DAL theloai;

        public bool Delete()
        {
            return theloai.Delete();
        }

        public bool Insert(TheLoai_DTO tl)
        {
            return theloai.Insert(tl);
        }

        public bool KiemTra(TheLoai_DTO tl)
        {
            if (tl.TenTheLoai == "")
                return false;
            return true;
        }

        public DataTable Select()
        {
            return theloai.Select();
        }
        
    }
}
