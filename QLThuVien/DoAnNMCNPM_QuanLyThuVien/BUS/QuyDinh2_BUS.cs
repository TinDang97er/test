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
   public class QuyDinh2_BUS
    {
        public QuyDinh2_BUS()
        {
            qdDAL = new QuyDinh2_DAL();
        }

        QuyDinh2_DAL qdDAL;

        public DataTable Select()
        {
            return qdDAL.Select();
        }

        public bool Update(QuyDinh2_DTO qd)
        {
            return qdDAL.Update(qd);
        }

        public bool KiemTra(QuyDinh2_DTO qd)
        {
            if (qd.HanNhanSach > 0 && qd.SoTheLoai>0)
                return true;
            return false;
        }
    }
}
