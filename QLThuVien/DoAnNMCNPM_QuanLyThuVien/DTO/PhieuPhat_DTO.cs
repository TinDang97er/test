using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNMCNPM_QuanLyThuVien.DTO
{
    public class PhieuPhat_DTO
    {
        string _MaPhieuTra;
    
        float _TongNo;
        public PhieuPhat_DTO()
        {
            MaPhieuTra = "";
      
            TongNo = 0;

        }
        public PhieuPhat_DTO(string maPhieuPhat, string maPhieuTra,float  tongNo  )
        {
        
            MaPhieuTra = maPhieuTra;
            TongNo = tongNo;
        }

        public string MaPhieuTra { get => _MaPhieuTra; set => _MaPhieuTra = value; }
     
        public float TongNo { get => _TongNo; set => _TongNo = value; }
    }
}
