using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class QuyDinh1_DTO
    {
        int _TuoiMin;
        int _TuoiMax;
        int _HanThe;
        public QuyDinh1_DTO()
        {
            TuoiMin = 18;
            TuoiMax = 55;
            HanThe = 6;
        }

        public QuyDinh1_DTO(int tuoiMin, int tuoiMax, int hanThe)
        {
            TuoiMin = tuoiMin;
            TuoiMax = tuoiMax;
            HanThe = hanThe;
        }

        public int TuoiMin { get => _TuoiMin; set => _TuoiMin = value; }
        public int TuoiMax { get => _TuoiMax; set => _TuoiMax = value; }
        public int HanThe { get => _HanThe; set => _HanThe = value; }
    }
}
