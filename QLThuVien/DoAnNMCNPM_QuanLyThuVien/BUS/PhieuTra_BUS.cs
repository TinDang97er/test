using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;

namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
    public class PhieuTra_BUS
    {
        public PhieuTra_BUS()
        {
            phieuTraDAL = new PhieuTra_DAL();
            
        }
       
        PhieuTra_DAL phieuTraDAL;

        public bool KiemTra(PhieuTra_DTO p)
        {
            if (p.MaPhieuTra == "" || p.MaThe == "" || p.MaThuThu == "" || p.NgayTra == "" )
                return false;
            return true;
        }

        public DataTable Select()
        {
            try
            {
                return phieuTraDAL.Select();
            }
            catch
            {
                return null;
            }
            
        }

        public  DataTable SelectCTMuon(string where)
        {
          
                return phieuTraDAL.SelectCTMuon(where);
                         
        }

        public DataTable SelectTen(string maThe)
        {
            return phieuTraDAL.SelectTen(maThe);
        }

        public bool Insert(PhieuTra_DTO p)
        {
            return phieuTraDAL.Insert(p);
        }

        public string SelectMaPhieuTraCuoi()
        {
            return phieuTraDAL.SelectMaPhieuTraCuoi();
        }
    }
}

