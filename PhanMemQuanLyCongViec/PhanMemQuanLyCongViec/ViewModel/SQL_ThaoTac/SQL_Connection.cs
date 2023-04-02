using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac
{
    public class SQL_Connection
    {
        private string stringConnection = @"Data Source=DESKTOP-VAV9QIG\SQLEXPRESS;Initial Catalog=QUANLYCONGVIEC;Integrated Security=True";
        private static SQL_Connection instance;
        public static SQL_Connection Instance
        {
            get { if (SQL_Connection.instance == null) SQL_Connection.instance = new SQL_Connection(); return SQL_Connection.instance; }
            private set { SQL_Connection.instance = value; }
        }
        private SQL_Connection() { }

        public DataTable ExecuteSQL(string stringQuerry)
        {
            SqlConnection QuanLyBanHangSQLconnection = new SqlConnection(stringConnection);
            SqlCommand querry = new SqlCommand(stringQuerry, QuanLyBanHangSQLconnection);
            SqlDataAdapter temporature = new SqlDataAdapter(querry);
            DataTable dataReturn = new DataTable();
            temporature.Fill(dataReturn);
            return dataReturn;
        }   // thực hiện câu truy vấn sql trả ra 1 datatable;
        public void ExecuteNONquerrySQL(string stringQuerry)
        {
            SqlConnection QuanLyBanHangSQLconnection = new SqlConnection(stringConnection);
            SqlCommand querry = new SqlCommand(stringQuerry, QuanLyBanHangSQLconnection);
            QuanLyBanHangSQLconnection.Open();
            querry.ExecuteNonQuery();
            QuanLyBanHangSQLconnection.Close();

        }   // thực hiện câu truy vấn sql không trả ra gì cả


    }
}
