using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class PhieuTra_DTO
    {

        string _MaPhieuTra;
        string _MaThe;
        string _MaThuThu;
        string _NgayTra;
        int _SoLuong;
        public PhieuTra_DTO()
        {
            MaPhieuTra = "";
            MaThe = "";
            MaThuThu = "";
            NgayTra = "";
            SoLuong = 0;
        }
        public PhieuTra_DTO(string maPhieuTra, string  maThe, string maThuThu, string ngayTra, int soLuong)
        {
            MaPhieuTra = maPhieuTra;
            MaThe = maThe;
            MaThuThu = maThuThu;
            NgayTra = ngayTra;
            SoLuong = soLuong;
        }

        public string MaPhieuTra { get => _MaPhieuTra; set => _MaPhieuTra = value; }
        public string MaThe { get => _MaThe; set => _MaThe = value; }
        public string MaThuThu { get => _MaThuThu; set => _MaThuThu = value; }
        public string NgayTra { get => _NgayTra; set => _NgayTra = value; }
       public int   SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
