using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class ChiTietMuonSach_DTO
    {
        private string maSach;
        private string maPhieuMuon;
        private string chuThich;
        public ChiTietMuonSach_DTO()
        {
            maSach = "";
            maPhieuMuon = "";
            chuThich = "";
        }
        public ChiTietMuonSach_DTO(string _maSach, string _maPhieuMuon, string _chuThich)
        {
            maPhieuMuon = _maPhieuMuon;
            maPhieuMuon = _maPhieuMuon;
            chuThich = _chuThich;
        }
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public string ChuThich { get => chuThich; set => chuThich = value; }

    }
}
