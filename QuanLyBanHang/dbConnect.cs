using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanHang
{
    class dbConnect
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=PC-PC\SQLEXPRESS;Database=QLBH;User Id=sa;Password = 12345;");

        public int ExcSQL(string strSQL)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand(strSQL,sqlcon);
            int rownum = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            return rownum;

        }

        public DataTable getData(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL,sqlcon);
            sqlcon.Open();
            sqlDa.Fill(dt);
            sqlcon.Close();
            return dt;
        }
    }
}
