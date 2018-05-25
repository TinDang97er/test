using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Data;
using System.Data.SqlClient;
using DoAnNMCNPM_QuanLyThuVien.DAL;


namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
  public  class ChiTietMuonSach_BUS
    {

        public ChiTietMuonSach_BUS()
        {
            CTMS = new ChiTietMuonSach_DAL();
        }

        ChiTietMuonSach_DAL CTMS;

        public bool KiemTra(ChiTietMuonSach_DTO ctms)
        {
            if (ctms.MaPhieuMuon == "" || ctms.MaSach == "")
                return false;
            return true;
        }

        public bool Insert(ChiTietMuonSach_DTO ctms)
        {
            return CTMS.Insert(ctms);
        }

        public bool Delete(ChiTietMuonSach_DTO ctms)
        {
            return CTMS.Delete(ctms);
        }
        
        public bool UpdateTTSach(ChiTietMuonSach_DTO ct)
        {
            return CTMS.UpdateTTSach(ct);
        }
    }
}
