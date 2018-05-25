using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Windows.Forms;

namespace DoAnNMCNPM_QuanLyThuVien.DAL
{
   public class PhieuPhat_DAL
    {

        public PhieuPhat_DAL()
        {
            Connect();
        }

        SqlConnection con;
        strConnecting connect;

        void Connect()
        {
            connect = new strConnecting();
            con = new SqlConnection(connect.strConnect);
        }

       public DataTable Select()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery = "select *from PHIEUTIENPHAT";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
                               
        }

        public bool Insert(PhieuPhat_DTO p)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"Insert into PHIEUTIENPHAT( MaPhieuTra, TongNo) values (N'" + p.MaPhieuTra + "'," + p.TongNo + ")";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {                          
                return false;
            }
        }

        public DataTable Search(string loai, string tuCanTim)
        {
           
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();

                string sqlQuery = @"select * from PHIEUTIENPHAT 
                                where " + loai + " LIKE N'" + "%" + tuCanTim + "%" + "'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;          
        }
    }
}
