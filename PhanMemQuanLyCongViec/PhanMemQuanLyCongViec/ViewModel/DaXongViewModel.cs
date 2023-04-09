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
using System.Collections.ObjectModel;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class DaXongViewModel : BaseViewModel
    {
        public ObservableCollection<HinhAnh> listHinhAnh { get; set; }
        #region commands
        public RelayCommand<ListView> chuaXongCommand { get; set; }
        public RelayCommand<ListView> xoaHinhCommand { get; set; }
        public RelayCommand<ListView> loadCommand { get; set; }
        #endregion
        public DaXongViewModel()
        {
            loadDuLieuHinhAnh();
            chuaXongCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {
                HinhAnh hinh = (HinhAnh)o.SelectedItem;
                hinh.DaXong = 0;
                if (HinhAnh_SQL.suaDuLieu(hinh))
                {
                    MessageBox.Show("Đã cập nhật !");
                    loadDuLieuHinhAnh(o);
                 
                }
                else
                {
                    MessageBox.Show("Lỗi !");
                }

            });
            xoaHinhCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {

                HinhAnh hinh = (HinhAnh)o.SelectedItem;
                MessageBoxResult choice = MessageBox.Show("Bạn có muốn chuyển thông tin hình này vào thùng rác ?", "", MessageBoxButton.YesNo);
                if (choice == MessageBoxResult.Yes)
                {
                    if (HinhAnh_SQL.xoaDuLieu(hinh) && HinhAnhBiXoa_SQL.themDuLieu(hinh))
                    {
                        MessageBox.Show("Đã chuyển vào thùng rác !");
                        loadDuLieuHinhAnh(o);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại !");
                    }
                }
                else
                { }
            });
            loadCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {
                loadDuLieuHinhAnh(o);
            });
        }
        void loadDuLieuHinhAnh(ListView listView)
        {
            listView.ItemsSource = null;
            listHinhAnh = new ObservableCollection<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH H,LOAIHINHANH LH WHERE H.MALOAI = LH.MALOAI AND DAXONG = 1");
            foreach (DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.MaHinh = int.Parse(row[0].ToString());
                hinh.TenHinh = row[1].ToString();
                hinh.KichCo = row[9].ToString();
                hinh.NgayGiaoHinh = row[2].ToString();
                hinh.SoDienThoaiKH = row[3].ToString();
                hinh.GiaHinh = decimal.Parse(row[4].ToString());
                hinh.GiaKhachCoc = decimal.Parse(row[5].ToString());
                hinh.ConLai = hinh.GiaHinh - hinh.GiaKhachCoc;
                hinh.GhiChu = row[6].ToString();
                hinh.TenLoai = row[11].ToString();
                hinh.MaLoai = int.Parse(row[8].ToString());
                hinh.DaXong = int.Parse(row[7].ToString());
                listHinhAnh.Add(hinh);
            }
            listView.ItemsSource = listHinhAnh;


        }
        void loadDuLieuHinhAnh()
        {
          
            listHinhAnh = new ObservableCollection<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH H,LOAIHINHANH LH WHERE H.MALOAI = LH.MALOAI AND DAXONG = 1");
            foreach (DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.MaHinh = int.Parse(row[0].ToString());
                hinh.TenHinh = row[1].ToString();
                hinh.KichCo = row[9].ToString();
                hinh.NgayGiaoHinh = row[2].ToString();
                hinh.SoDienThoaiKH = row[3].ToString();
                hinh.GiaHinh = decimal.Parse(row[4].ToString());
                hinh.GiaKhachCoc = decimal.Parse(row[5].ToString());
                hinh.ConLai = hinh.GiaHinh - hinh.GiaKhachCoc;
                hinh.GhiChu = row[6].ToString();
                hinh.TenLoai = row[11].ToString();
                hinh.MaLoai = int.Parse(row[8].ToString());
                hinh.DaXong = int.Parse(row[7].ToString());
                listHinhAnh.Add(hinh);
            }


        }
    }
}
