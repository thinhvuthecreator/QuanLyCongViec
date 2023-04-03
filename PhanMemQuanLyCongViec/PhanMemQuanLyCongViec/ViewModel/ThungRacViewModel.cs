using PhanMemQuanLyCongViec.Model;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class ThungRacViewModel : BaseViewModel
    {
        public List<HinhAnh> listHinhAnh { get; set; }

        public ThungRacViewModel()
        {
            loadDuLieuHinhAnh();
        }


        void loadDuLieuHinhAnh()
        {
            listHinhAnh = new List<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANHBIXOA H,LOAIHINHANH LH WHERE H.MALOAI = LH.MALOAI");
            foreach (DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.MaHinh = int.Parse(row[0].ToString());
                hinh.MaLoai = int.Parse(row[8].ToString());
                hinh.TenHinh = row[1].ToString();
                hinh.SoDienThoaiKH = row[3].ToString();
                hinh.GiaHinh = decimal.Parse(row[4].ToString());
                hinh.GiaKhachCoc = decimal.Parse(row[5].ToString());
                hinh.ConLai = hinh.GiaHinh - hinh.GiaKhachCoc;
                hinh.GhiChu = row[6].ToString();
                hinh.TenLoai = row[11].ToString();
                hinh.DaXong = int.Parse(row[7].ToString()); // lỗi ở đây   0.ToString() không trả về "0" mà trả về vớ vẩn
                hinh.DaXongString = hinh.DaXong == 1 ? "Đã xong" : "Chưa xong";
                listHinhAnh.Add(hinh);

            }

        }
    }
}
