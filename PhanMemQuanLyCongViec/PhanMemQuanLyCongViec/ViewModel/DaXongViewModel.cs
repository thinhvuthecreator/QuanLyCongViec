using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemQuanLyCongViec.View;
using PhanMemQuanLyCongViec.Model;
using System.Data;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using System.Windows.Controls;
using System.Windows;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class DaXongViewModel : BaseViewModel
    {
        public List<HinhAnh> listHinhAnh { get; set; }
        public DaXongViewModel()
        {
            loadDuLieuHinhAnh();
        }
        void loadDuLieuHinhAnh()
        {
            listHinhAnh = new List<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH H,LOAIHINHANH LH WHERE H.MALOAI = LH.MALOAI AND DAXONG = 1");
            foreach (DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.TenHinh = row[1].ToString();
                hinh.NgayGiaoHinh = row[2].ToString();
                hinh.SoDienThoaiKH = row[3].ToString();
                hinh.GiaHinh = decimal.Parse(row[4].ToString());
                hinh.GiaKhachCoc = decimal.Parse(row[5].ToString());
                hinh.ConLai = hinh.GiaHinh - hinh.GiaKhachCoc;
                hinh.GhiChu = row[6].ToString();
                hinh.TenLoai = row[11].ToString();
                listHinhAnh.Add(hinh);

            }

        }
    }
}
