using PhanMemQuanLyCongViec.Model;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class CapNhatThongTinViewModel : BaseViewModel
    {
        #region model
        static public HinhAnh hinhAnh { get; set; }
        #endregion

        #region commands
        public RelayCommand<Window> suaHinhCommand { get; set; }
        public RelayCommand<Window> huyCommand { get; set; }

        #endregion


        public CapNhatThongTinViewModel()
        {
            suaHinhCommand = new RelayCommand<Window>((o) => { return true; }, (o) =>
            {
                hinhAnh.MaHinh = ThongTinHinhDaChon.MaHinh; // return dữ liệu mã hình đã chọn vào hinhAnh để cập nhật
                if (HinhAnh_SQL.suaDuLieu(hinhAnh))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    o.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                }
            });
            huyCommand = new RelayCommand<Window>((o) => { return true; }, (o) =>
            {
                o.Close();
            });
        }

        #region methods
        void khoiTaoDuLieuHinhAnh(HinhAnh hAnh)
        { 
            hAnh.TenHinh = ThongTinHinhDaChon.TenHinh;
            hAnh.KichCo = ThongTinHinhDaChon.KichCo;
            hAnh.GiaHinh = ThongTinHinhDaChon.GiaHinh;
            hAnh.GiaKhachCoc = ThongTinHinhDaChon.GiaKhachCoc;
            hAnh.SoDienThoaiKH = ThongTinHinhDaChon.SoDienThoaiKH;
            hAnh.GhiChu = ThongTinHinhDaChon.GhiChu;
            hAnh.NgayGiaoHinh = ThongTinHinhDaChon.NgayGiaoHinh;
            hAnh.DaXong = ThongTinHinhDaChon.DaXong;
            hAnh.MaLoai = LoaiHinhDaChon.MaLoai;

        }
        #endregion

    }
}
