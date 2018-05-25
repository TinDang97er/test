using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
  public  class QuyDinh2_DTO
    {
        int _SoTheLoai;
        int _HanNhanSach;

        public QuyDinh2_DTO()
        {
            SoTheLoai = 3;
            HanNhanSach = 8;
        }

        public QuyDinh2_DTO( int soTheLoai, int hanNhanSach)
        {
            SoTheLoai = soTheLoai;
            HanNhanSach = hanNhanSach;
        }

        public int SoTheLoai { get => _SoTheLoai; set => _SoTheLoai = value; }
        public int HanNhanSach { get => _HanNhanSach; set => _HanNhanSach = value; }
    }
}
