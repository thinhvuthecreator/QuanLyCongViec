using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PhanMemQuanLyCongViec.Model;

namespace PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac
{
    public class LoaiHinhAnh_SQL
    {
        public static DataTable loadDulieu()
        {
            DataTable dataLoaiHinhAnh = new DataTable();
            dataLoaiHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM LOAIHINHANH");
            return dataLoaiHinhAnh;
        }

        public static bool themDuLieu(LoaiHinhAnh loaiHinh)
        {
            bool isSuccess = true;
            try
            {
                string addQuerry = "INSERT LOAIHINHANH VALUES(N'" + loaiHinh.TenLoaiHinh + "')";
                SQL_Connection.Instance.ExecuteNONquerrySQL(addQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public static bool xoaDuLieu(string  tenLoai)   // xóa tên loại vì tên loại là unique ko bị trùng lặp
        {
            bool isSuccess = true;
            try
            {
                string deleteQuerry = "DELETE FROM LOAIHINHANH WHERE TENLOAI = N'" + tenLoai +"'";
                SQL_Connection.Instance.ExecuteNONquerrySQL(deleteQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public static bool suaDuLieu(LoaiHinhAnh loaiHinh)
        {
            bool isSuccess = true;
            try
            {
                string updateQuerry = "UPDATE LOAIHINHANH SET TENLOAI = N'" + loaiHinh.TenLoaiHinh +"'";
                SQL_Connection.Instance.ExecuteNONquerrySQL(updateQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}
