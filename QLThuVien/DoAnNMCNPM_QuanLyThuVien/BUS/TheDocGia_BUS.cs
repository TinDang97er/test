using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;

namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
   public class TheDocGia_BUS
    {
        TheDocGia_DAL TDG;

        public TheDocGia_BUS()
        {
            TDG = new TheDocGia_DAL();
        }

       public bool KiemTra(TheDocGia_DTO thedocgia)
        {
            if (thedocgia.MaThe == "" || thedocgia.MaDocGia == "" || thedocgia.NgayLamThe == "" || thedocgia.HanThe == "" || thedocgia.LoaiThe == "")
                return false;
            return true;
        }

        public bool Insert(TheDocGia_DTO thedocgia)
        {
            return TDG.Insert(thedocgia);

        }

        public DataTable Select()
        {
            return TDG.Select();
        }

        public bool UpDate(TheDocGia_DTO thedocgia)
        {
            return TDG.UpDate(thedocgia);

        }

        public bool Delete(TheDocGia_DTO thedocgia)
        {
            return TDG.Delete(thedocgia);
        }

        public DataTable Search(string loai, string tuCanTim)
        {
            return TDG.Search(loai, tuCanTim);
        }

        public DataTable TimTenNgaySinhDocGia(string maDocGia)
        {
            return TDG.TimTenNgaySinhDocGia(maDocGia);
        }
        
        public bool KTDocGiaCoTonTaiTrongDsThe(string maDocGia)
        {
            return TDG.KTDocGiaCoTonTaiTrongDsThe(maDocGia);
        }
    }
}
