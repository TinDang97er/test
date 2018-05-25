using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
    public class CuonSach_DTO
    {
        private string _MaSach;
        private string _MaDauSach;
        private string _TinhTrang;
        private string _NgayNhap;
        private string _ChuThich;

        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string MaDauSach { get => _MaDauSach; set => _MaDauSach = value; }
        public string TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public string NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
        public string ChuThich { get => _ChuThich; set => _ChuThich = value; }
    }
}
