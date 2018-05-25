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
  public   class ChiTietTraSach_BUS
    {
        public ChiTietTraSach_BUS()
        {
            ctDAL = new ChiTietTraSach_DAL();
        }

        ChiTietTraSach_DAL ctDAL;

      public  bool KiemTra(ChiTietTraSach_DTO ctDTO)
        {
            if (ctDTO.MaPhieuMuon == "" || ctDTO.MaPhieuTra == "" || ctDTO.MaSach == "")
                return false;
            return true;
        }

        public bool Insert(ChiTietTraSach_DTO ctDTO)
        {
            return ctDAL.Insert(ctDTO);
        }

        public DataTable SelectTTTraSach(ChiTietTraSach_DTO ct)
        { return ctDAL.SelectTTSachTra(ct);
        }

        public bool Delete(ChiTietTraSach_DTO ct)
        {
            return ctDAL.Delete(ct);
        }

        public bool UpDate(ChiTietTraSach_DTO ct)
        {
           return  ctDAL.Updtate(ct);

        }

        public bool UpdateTTSach(ChiTietTraSach_DTO ct)
        {
            return ctDAL.UpdateTTSach( ct);
        }
    }
}
