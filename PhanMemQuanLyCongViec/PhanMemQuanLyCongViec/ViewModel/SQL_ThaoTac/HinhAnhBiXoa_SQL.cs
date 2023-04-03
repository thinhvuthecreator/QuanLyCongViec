using PhanMemQuanLyCongViec.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac
{
    public class HinhAnhBiXoa_SQL
    {
        public static DataTable loadDulieu()
        {
            DataTable dataHinhAnh = new DataTable();
            dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANHBIXOA");
            return dataHinhAnh;
        }

        public static bool themDuLieu(HinhAnh hinh)
        {
            bool isSuccess = true;
            try
            {
                string addQuerry = "INSERT HINHANHBIXOA VALUES(N'" + hinh.TenHinh + "',N'" + hinh.NgayGiaoHinh + "',N'" + hinh.SoDienThoaiKH + "'," + hinh.GiaHinh + "," + hinh.GiaKhachCoc + ",N'" + hinh.GhiChu + "'," + hinh.DaXong + "," + hinh.MaLoai + ",N'" + hinh.KichCo + "')";
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
                string deleteQuerry = "DELETE FROM HINHANHBIXOA WHERE MAHINH = " + hinh.MaHinh;
                SQL_Connection.Instance.ExecuteNONquerrySQL(deleteQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}
