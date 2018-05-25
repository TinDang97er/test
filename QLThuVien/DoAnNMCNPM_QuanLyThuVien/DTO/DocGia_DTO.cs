using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class DocGia_DTO
    {
        string _MaDocGia;
        string _HoTen;
        string _GioiTinh;
        string _NgaySinh;
        string _DiaChi;
        string _Email;
        public DocGia_DTO()
        {
            MaDocGia = "";
            HoTen = "";
            GioiTinh = "";
            NgaySinh = "";
            DiaChi = "";
            Email = "";
        }
        public DocGia_DTO(string madocgia, string hoten, string gioitinh, string ngaysinh, string diachi, string email)
        {
            MaDocGia = madocgia;
            HoTen = hoten;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
            DiaChi = diachi;
            Email = email;

        }

        public string MaDocGia { get => _MaDocGia; set => _MaDocGia = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
