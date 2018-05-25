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
    public class ThuThu_BUS
    {
        ThuThu_DAL TT;

        public ThuThu_BUS()
        {
            TT = new ThuThu_DAL();
        }

         public  bool KiemTra(ThuThu_DTO thuthu)
        {
            if (thuthu.MaThuThu == "" || thuthu.HoTen == "" || thuthu.DiaChi == "" || thuthu.Email == "" || thuthu.ChucVu == ""||thuthu.HoTen.Length<0)
                return false;
            return true; 
        } 

        public bool Insert(ThuThu_DTO thuthu)
        {
            return TT.Insert(thuthu);
                            
       } 

        public DataTable Select()
        {
            return TT.Select();
        }

        public bool Update(ThuThu_DTO thuthu)
        {
            return TT.UpDate(thuthu);             
        }

        public bool Delete(ThuThu_DTO thuthu)
        {
            return TT.Delete(thuthu);
        }

        public DataTable Search(string loai, string tuCanTim)
        {
            return TT.Search(loai, tuCanTim);
        }
      
    }
}
