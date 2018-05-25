using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class PhieuMuon_DTO
    {
        private string maPhieuMuon;
        private string maThuThu;
        private string maThe;
        private string ngayMuon;
        private string ngayDuKienTra;
        private string hoTen;
        private int soLuong;
        public PhieuMuon_DTO()
        {
            maPhieuMuon = "";
            maThuThu = "";
            maThe = "";
            ngayMuon = "";
            ngayDuKienTra = "";
            hoTen = "";
            soLuong = 0;


        }
        public PhieuMuon_DTO(string _maPhieuMuon, string _maThuThu, string _maThe, string _ngayMuon, string _ngayDuKienTra, string _hoTen, int _soLuong)
        {
            maPhieuMuon = _maPhieuMuon;
            maThuThu = _maThuThu;
            maThe = _maThe;
            ngayMuon = _ngayMuon;
            ngayDuKienTra = _ngayDuKienTra;
            hoTen = _hoTen;
            soLuong = _soLuong;

        }

        public string MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public string MaThuThu { get => maThuThu; set => maThuThu = value; }
        public string MaThe { get => maThe; set => maThe = value; }
        public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgayDuKienTra { get => ngayDuKienTra; set => ngayDuKienTra = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
