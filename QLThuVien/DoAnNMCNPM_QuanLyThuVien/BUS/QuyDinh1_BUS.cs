using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;
using System.Data;

namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
    public class QuyDinh1_BUS
    {
      public  QuyDinh1_BUS()
        {
            qdDAL = new QuyDinh1_DAL();
        }

        QuyDinh1_DAL qdDAL;

        public DataTable Select ()
        {
            return qdDAL.Select();
        }

        public bool Update(QuyDinh1_DTO qd)
        {
            return qdDAL.Update(qd);
        }

        public bool KiemTra(QuyDinh1_DTO qd)
        {
            if (qd.TuoiMin < qd.TuoiMax && qd.HanThe >0  && qd.TuoiMax>0 && qd.TuoiMin>0)
                return true;
            return false;
        }
    }
}
