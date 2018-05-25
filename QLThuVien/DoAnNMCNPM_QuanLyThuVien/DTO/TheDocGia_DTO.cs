using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
    public class TheDocGia_DTO
    {
        string _MaThe;
        string _MaDocGia;
        string _NgayLamThe;
        string _HanThe;
        string _LoaiThe;

        public TheDocGia_DTO()
        {
            MaThe = "";
            MaDocGia = "";
            NgayLamThe = "";
            HanThe = "";
            LoaiThe = "";


        }

        public TheDocGia_DTO(string mathe, string madocgia, string ngaylamthe, string hanthe, string loaithe)
        {
            MaThe = mathe;
            MaDocGia = madocgia;
            NgayLamThe = ngaylamthe;
            HanThe = hanthe;
            LoaiThe = loaithe;

        }

        public string MaThe { get => _MaThe; set => _MaThe = value; }
        public string MaDocGia { get => _MaDocGia; set => _MaDocGia = value; }
        public string NgayLamThe { get => _NgayLamThe; set => _NgayLamThe = value; }
        public string HanThe { get => _HanThe; set => _HanThe = value; }
        public string LoaiThe { get => _LoaiThe; set => _LoaiThe = value; }
    }
}
