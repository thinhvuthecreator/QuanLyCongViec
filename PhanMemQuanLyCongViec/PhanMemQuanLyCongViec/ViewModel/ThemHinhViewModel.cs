using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PhanMemQuanLyCongViec.Model;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class ThemHinhViewModel : BaseViewModel
    {
        #region model
        public HinhAnh hinhAnh = new HinhAnh();
        #endregion

        #region properties
        public string TenHinh { get; set; } = "A";
        public string KichCo { get; set; } = "B";
        public decimal GiaHinh { get; set; } = 90;
        public decimal GiaKhachCoc { get; set; } = 4;
        public string SoDienThoaiKH { get; set; } = "a";
        public string GhiChu { get; set; } = "4";
        public int MaLoai { get; set; }
        public string NgayGiaoHinh { get; set; } = "4";
        public int MaHinh { get; set; }
        public int DaXong { get; set; }

        #endregion

        #region commands
        public RelayCommand<Window> themHinhCommand { get; set; }
        public RelayCommand<Window> huyCommand { get; set; }

        #endregion
        public ThemHinhViewModel()
        {
            themHinhCommand = new RelayCommand<Window>((o) => { return true; }, (o) =>
            {

                khoiTaoDuLieuHinhAnh(hinhAnh);
                if(HinhAnh_SQL.themDuLieu(hinhAnh))
                {
                    MessageBox.Show("Thêm thành công !");
                    o.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại !");
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
            hAnh.TenHinh = TenHinh;
            hAnh.KichCo = KichCo;
            hAnh.GiaHinh = GiaHinh;
            hAnh.GiaKhachCoc = GiaKhachCoc;
            hAnh.SoDienThoaiKH = SoDienThoaiKH;
            hAnh.GhiChu = GhiChu;
            hAnh.MaLoai = MaLoai;
            hAnh.NgayGiaoHinh = NgayGiaoHinh;
            hAnh.DaXong = DaXong;

        }
        FrameworkElement getParent(Button btn)
        {
            FrameworkElement parent = btn;
            while(parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;

        }
        #endregion

    }
}
