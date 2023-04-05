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
        public HinhAnh hinhAnh { get; set; } = new HinhAnh();
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

        #endregion

    }
}
