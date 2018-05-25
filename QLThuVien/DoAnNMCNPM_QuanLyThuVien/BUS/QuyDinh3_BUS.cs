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
    public class QuyDinh3_BUS
    {
        public QuyDinh3_BUS()
        {
            qdBUS = new QuyDinh3_DAL();
        }

        QuyDinh3_DAL qdBUS;

         public bool KiemTra(QuyDinh3_DTO qd)
        {
            if (qd.SoLuongSachToiDa >0 && qd.SoNgayMuonToiDa >0)
                return true;
            return false;
        }

        public bool Update (QuyDinh3_DTO qd)
        {
            return qdBUS.Update(qd);
        }

        public DataTable Select()
        {
            return qdBUS.Select();
        }

    }
}
