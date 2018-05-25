using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using DoAnNMCNPM_QuanLyThuVien.DAL;

namespace DoAnNMCNPM_QuanLyThuVien.BUS
{
    public class DocGia_BUS
    {
        DocGia_DAL DG;

        public DocGia_BUS()
        {
            DG = new DocGia_DAL();
        }

       public bool KiemTra(DocGia_DTO docgia)
        {
            if (docgia.MaDocGia == "" || docgia.HoTen == "" || docgia.GioiTinh == "" || docgia.NgaySinh == "" || docgia.DiaChi == "" || docgia.Email == ""||docgia.HoTen.Length<0)
                return false;
            return true;
        }

        public bool Insert(DocGia_DTO docgia)
        {
            return DG.Insert(docgia);
        }

        public DataTable Select()
        {
            return DG.Select();
        }

        public bool UpDate(DocGia_DTO docgia)
        {
            return DG.Update(docgia);

        }

        public bool Delete(DocGia_DTO docgia)
        {
            return DG.Delete(docgia);
        }

        public DataTable Search(string loai, string tuCanTim)
        {
            return DG.Search(loai, tuCanTim);
        }
    }
}
