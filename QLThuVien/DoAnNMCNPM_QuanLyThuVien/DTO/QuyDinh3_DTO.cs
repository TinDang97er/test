using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
   public class QuyDinh3_DTO
    {
        private int soLuongSachToiDa;
        private int soNgayMuonToiDa;
       

        public QuyDinh3_DTO()
        {
            soLuongSachToiDa = 5;
            soNgayMuonToiDa = 4;
           
        }
        public QuyDinh3_DTO(int _soLuongSachToiDa, int _soNgayMuonToiDa)
        {
            soLuongSachToiDa = _soLuongSachToiDa;
            soNgayMuonToiDa = _soNgayMuonToiDa;
            
        }
        public int SoLuongSachToiDa { get => soLuongSachToiDa; set => soLuongSachToiDa = value; }
        public int SoNgayMuonToiDa { get => soNgayMuonToiDa; set => soNgayMuonToiDa = value; }
       
    }
}
