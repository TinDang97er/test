using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;
using System.Windows.Forms;
using System.Data;

namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
  public  class PhieuMuon_BUS
    {

        PhieuMuon_DAL MS;

        public PhieuMuon_BUS()
        {
            MS = new PhieuMuon_DAL();
        }

        public   bool KiemTra(PhieuMuon_DTO muonSach)
        {
            if ( muonSach.MaPhieuMuon == "" || muonSach.MaThe == "" || muonSach.MaThuThu == "" || muonSach.NgayDuKienTra == "" || muonSach.NgayMuon == "")
                return false;
            return true;
        }

        public bool Insert (PhieuMuon_DTO muonSach)
        {
            return MS.Insert(muonSach);
         
        }
      
        public DataTable Select()
        {
            return MS.Select();
        }

        public DataTable TimKiem(string TimKiemTheo, string tuCanTim)
        {
            return MS.TimKiem(TimKiemTheo, tuCanTim);
        }

        public string  TimTen(string maThe)
        {
            return MS.TimTen(maThe);
        }

        public string SoLuongSachMuonTuTruoc(string mathe)
        {
            return MS.SoLuongSachMuonTuTruoc(mathe);
        }

        public string  HanThe(string maThe)
        {
            return MS.HanThe(maThe);
        }

        public string SelectMaPhieuMuonCuoi()
        {
            return MS.SelectMaPhieuMuonCuoi();
        }

        public DataTable SelectTTPMkhongTonTaiTrongMaPhieuTra()
        {
            return MS.SelectTTPMkhongTonTaiTrongMaPhieuTra();
        }

        public DataTable SearchTTSachChuaTra(string loai, string tuCanTim)
        {
            return MS.SearchTTSachChuaTra(loai, tuCanTim);
        }
        public DataTable SelectTTCTSachChuaTra(string maPhieuMuon)
        {
            return MS.SelectTTCTSachChuaTra(maPhieuMuon);
        }
    }
}
