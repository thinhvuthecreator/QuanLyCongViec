using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PhanMemQuanLyCongViec.View;
using PhanMemQuanLyCongViec.Model;
using System.Data;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using System.Windows.Controls;
using System.Windows;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class QuanLyHinhViewModel : BaseViewModel
    {
        public List<HinhAnh> listHinhAnh { get; set; }
        #region commands
        public RelayCommand<object> addHinhCommand { get; set; }
        public RelayCommand<ListView> daXongCommand { get; set; }
        #endregion
        public QuanLyHinhViewModel()
        {
            loadDuLieuHinhAnh();
            addHinhCommand = new RelayCommand<object>((o) => { return true;}, (o) =>
            {
                ThemHinhView themHinhWindow = new ThemHinhView();
                themHinhWindow.ShowDialog();
               
            });
            daXongCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {
                HinhAnh hinh =  (HinhAnh)o.SelectedItem;
                hinh.DaXong = 1;
                if (HinhAnh_SQL.suaDuLieu(hinh))
                {
                    MessageBox.Show("Đã cập nhật !");
                }
                else
                {
                    MessageBox.Show("Lỗi !");
                }

            });
        }
        void loadDuLieuHinhAnh()
        {
            listHinhAnh = new List<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH WHERE MALOAI = " + LoaiHinhDaChon.MaLoai);
            foreach(DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.TenHinh = row[1].ToString();
                hinh.NgayGiaoHinh = row[2].ToString();
                hinh.SoDienThoaiKH = row[3].ToString();
                hinh.GiaHinh = decimal.Parse(row[4].ToString());
                hinh.GiaKhachCoc = decimal.Parse(row[5].ToString());
                hinh.ConLai = hinh.GiaHinh - hinh.GiaKhachCoc;
                hinh.GhiChu = row[6].ToString();
                listHinhAnh.Add(hinh);

            }

        }




    }
}
