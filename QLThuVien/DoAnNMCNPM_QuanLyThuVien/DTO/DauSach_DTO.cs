using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class DauSach_DTO
    {
        string _MaDauSach;
        string _TenDauSach;
        string _TacGia;
        string _TenTheLoai;
        int _NamSanXuat;
        string _NhaSanXuat;
        float _Gia;
        int _SoLuong;

        public DauSach_DTO()
        {
            MaDauSach = "";
            TenDauSach = "";
            TacGia = "";
            TenTheLoai = "";
            NamSanXuat = 0;
            NhaSanXuat = "";
            Gia = 0;
            SoLuong = 0;
        }
        public DauSach_DTO(string madausach, string tendausach, string tacgia, string tentheloai, int namsanxuat, string nhasanxuat, float gia, int soluong)
        {
            MaDauSach = madausach;
            TenDauSach = tendausach;
            TacGia = tacgia;
            TenTheLoai = tentheloai;
            NamSanXuat = namsanxuat;
            NhaSanXuat = nhasanxuat;
            Gia = gia;
            SoLuong = soluong;
        }


        public string MaDauSach { get => _MaDauSach; set => _MaDauSach = value; }
        public string TenDauSach { get => _TenDauSach; set => _TenDauSach = value; }
        public string TacGia { get => _TacGia; set => _TacGia = value; }
        public string TenTheLoai { get => _TenTheLoai; set => _TenTheLoai = value; }
        public int NamSanXuat { get => _NamSanXuat; set => _NamSanXuat = value; }
        public string NhaSanXuat { get => _NhaSanXuat; set => _NhaSanXuat = value; }
        public float Gia { get => _Gia; set => _Gia = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }

    }
}
