using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;


namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
    public class DauSach_BUS
    {
        DauSach_DAL DS;

        public DauSach_BUS()
        {
            DS = new DauSach_DAL();
        }

        public   bool KiemTra(DauSach_DTO dausach)
        {
            if (dausach.MaDauSach == "" || dausach.TenDauSach == "" || dausach.TacGia == "" || dausach.TenTheLoai == "" || dausach.NamSanXuat == 0 || dausach.NhaSanXuat == "" || dausach.Gia == 0||dausach.TenDauSach.Length<0)
                return false;
            return true;
        }

        public bool Insert(DauSach_DTO dausach)
        {
            return DS.Insert(dausach);
        }

        public DataTable Select()
        {
            return DS.Select();
        }

        public bool Update(DauSach_DTO dausach)
        {
             return DS.UpDate(dausach);
                        
        }

        public bool Delete(DauSach_DTO dausach)
        {
            return DS.Delete(dausach);            
        }

        public DataTable Search(string loai, string tucantim)
        {
            return DS.Search(loai, tucantim);
        }
    }
}
