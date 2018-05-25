using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
    public class ThuThu_DTO
    {
        string _MaThuThu;
        string _HoTen;
        string _NgaySinh;
        string _GioiTinh;
        string _DiaChi;
        string _Email;
        string _ChucVu;
        public ThuThu_DTO()
        {
            MaThuThu = "";
            HoTen = "";
            GioiTinh = "";
            Email = "";
            ChucVu = "";

        }

        public ThuThu_DTO(string mathuthu, string hoten,string ngaysinh, string gioitinh, string diachi,string email,string chucvu)
        {
            MaThuThu = mathuthu;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            DiaChi = diachi;
            Email = email;
            ChucVu = chucvu;
        }

        public string MaThuThu { get => _MaThuThu; set => _MaThuThu = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
    }


}
