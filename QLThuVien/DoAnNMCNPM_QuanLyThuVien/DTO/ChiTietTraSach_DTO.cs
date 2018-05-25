using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class ChiTietTraSach_DTO
    {
        string _MaPhieuTra;
        string _maPhieuMuon;
        string _MaSach;
        int _SoNgayTraMuon;
        string _ChuThich;

        public ChiTietTraSach_DTO()
        {
            MaPhieuMuon = "";
            MaPhieuTra = "";
            MaSach = "";
            SoNgayTraMuon = 0;
            ChuThich = "";

        }

        public ChiTietTraSach_DTO(string maPhieuMuon, string maPhieuTra, string maSach, int soNgayTraMuon, string chuThich)
        {
            MaPhieuTra = maPhieuTra;
            MaPhieuMuon = maPhieuMuon;
            MaSach = maSach;
            SoNgayTraMuon = soNgayTraMuon;
            ChuThich = chuThich;
        }

        public string MaPhieuTra { get => _MaPhieuTra; set => _MaPhieuTra = value; }
        public string MaPhieuMuon { get => _maPhieuMuon; set => _maPhieuMuon = value; }
        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public int SoNgayTraMuon { get => _SoNgayTraMuon; set => _SoNgayTraMuon = value; }
        public string ChuThich { get => _ChuThich; set => _ChuThich = value; }
    }
}
