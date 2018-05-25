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
   public  class TheLoai_DAL
    {
        public TheLoai_DAL()
        {
            Connect();
        }

        SqlConnection con;
        strConnecting conect;

        void Connect()
        {
            conect = new strConnecting();

            con = new SqlConnection(conect.strConnect);
        }

        public bool Insert(TheLoai_DTO tl)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"Insert into THELOAISACH values(N'" + tl.TenTheLoai + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool Delete()
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                   string sqlQuery = @"Delete from THELOAISACH";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch(Exception e)
                {
                MessageBox.Show(e.ToString());
                    return false;
                }

            }

        public DataTable Select()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = "select *from THELOAISACH";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            DataTable table = new DataTable();
            aDapter.Fill(table);
            return table;
        }
    }
}
