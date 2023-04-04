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
        public HinhAnh hinhAnh = new HinhAnh();
        #endregion

        #region properties
        public string TenHinh { get; set; }
        public string KichCo { get; set; }
        public decimal GiaHinh { get; set; }
        public decimal GiaKhachCoc { get; set; }
        public string SoDienThoaiKH { get; set; }
        public string GhiChu { get; set; }
        public int MaLoai { get; set; }
        public string NgayGiaoHinh { get; set; }
        public int MaHinh { get; set; }
        public int DaXong { get; set; } = 0;
        #endregion

        #region commands
        public RelayCommand<Window> suaHinhCommand { get; set; }
        public RelayCommand<Window> huyCommand { get; set; }

        #endregion


        public CapNhatThongTinViewModel()
        {
            suaHinhCommand = new RelayCommand<Window>((o) => { return true; }, (o) =>
            {

                khoiTaoDuLieuHinhAnh(hinhAnh);
                if (HinhAnh_SQL.suaDuLieu(hinhAnh))
                {
                    MessageBox.Show("Cập nhật  thành công !");
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
            hAnh.MaHinh = MaHinh;
            hAnh.TenHinh = TenHinh;
            hAnh.KichCo = KichCo;
            hAnh.GiaHinh = GiaHinh;
            hAnh.GiaKhachCoc = GiaKhachCoc;
            hAnh.SoDienThoaiKH = SoDienThoaiKH;
            hAnh.GhiChu = GhiChu;
            hAnh.NgayGiaoHinh = NgayGiaoHinh;
            hAnh.DaXong = DaXong;
            hAnh.MaLoai = LoaiHinhDaChon.MaLoai;

        }
        #endregion

    }
}
