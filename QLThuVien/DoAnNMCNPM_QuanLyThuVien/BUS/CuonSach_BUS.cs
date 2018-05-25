using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;
using System.Data;

namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
    public class CuonSach_BUS
    {
        public CuonSach_BUS ()
        {
            cuonsach = new CuonSach_DAL();
        }

        CuonSach_DAL cuonsach;

        public bool KiemTra(CuonSach_DTO cs)
        {
            if (cs.MaSach == "" || cs.MaDauSach == "" || cs.TinhTrang == "" || cs.NgayNhap == "")
                return false;
            return true;

        }

        public DataTable Select()
        {
            return cuonsach.Select();
        }

        public bool Insert(CuonSach_DTO cs)
        {
            return cuonsach.Insert(cs);
        }

        public bool Delete(CuonSach_DTO cs)
        {
            return cuonsach.Delete(cs);
        }

        public bool Update(CuonSach_DTO cs)
        {
            return cuonsach.Update(cs);
        }

        public DataTable SelectCTClick(string madausach)
        {
            return cuonsach.SelectCTClick(madausach);

        }

        public DataTable SelectCTEnter(string maDauSach)
        {
            return cuonsach.SelectCTEnter(maDauSach);
        }

        public DataTable SelectMaDauSach(string maSach)
        {
            return cuonsach.SelectMaDauSach(maSach);
        }

        public DataTable Search(string loai, string tuCanTim)
        {
            return cuonsach.Search(loai, tuCanTim);
        }

        public DataTable SelectListMaDauSach()
        {
            return cuonsach.SelectListMaDauSach();
        }
    }
}
