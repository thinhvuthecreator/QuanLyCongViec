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
    public class HinhAnh_SQL
    {
        public static DataTable loadDulieu()
        {
            DataTable dataHinhAnh = new DataTable();
            dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH");
            return dataHinhAnh;
        }

        public static bool themDuLieu(HinhAnh hinh)
        {
            bool isSuccess = true;
            try
            {
                string addQuerry = "INSERT HINHANH VALUES(N'" + hinh.TenHinh + "',N'" + hinh.NgayGiaoHinh + "',N'"+ hinh.SoDienThoaiKH + "'," + hinh.GiaHinh +"," + hinh.GiaKhachCoc +",N'" + hinh.GhiChu +"'," + hinh.DaXong +"," + hinh.MaLoai +",N'" + hinh.KichCo + "')";
                SQL_Connection.Instance.ExecuteNONquerrySQL(addQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public static bool xoaDuLieu(HinhAnh hinh)
        {
            bool isSuccess = true;
            try
            {
                string deleteQuerry = "DELETE FROM HINHANH WHERE MAHINH = " + hinh.MaHinh;
                SQL_Connection.Instance.ExecuteNONquerrySQL(deleteQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public static bool suaDuLieu(HinhAnh hinh)
        {
            bool isSuccess = true;
            try
            {
                string updateQuerry = "UPDATE HINHANH SET TENHINH = N'" + hinh.TenHinh + "', NGAYGIAOHINH = N'" + hinh.NgayGiaoHinh + "',SDTKHACHGIAO = N'" + hinh.SoDienThoaiKH + "',GIAHINH =" + hinh.GiaHinh +",TIENKHACHCOC = " + hinh.GiaKhachCoc + ",GHICHU = N'" + hinh.GhiChu + "',DAXONG = " + hinh.DaXong + " WHERE MAHINH =" + hinh.MaHinh;
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
