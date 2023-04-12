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
using System.Collections.ObjectModel;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class QuanLyHinhViewModel : BaseViewModel
    {
        public ObservableCollection<HinhAnh> listHinhAnh { get; set; }
        #region commands
        public RelayCommand<object> addHinhCommand { get; set; }
        public RelayCommand<ListView> daXongCommand { get; set; }
        public RelayCommand<ListView> xoaHinhCommand { get; set; }
        public RelayCommand<ListView> capNhatCommand { get; set; }
        public RelayCommand<ListView> loadCommand { get; set; }
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
                if (hinh == null)
                {
                    MessageBox.Show("Vui lòng chọn hình cần cập nhật");
                }
                else
                {
                    hinh.DaXong = 1;
                    if (HinhAnh_SQL.suaDuLieu(hinh))
                    {
                        MessageBox.Show("Đã cập nhật !");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi !");
                    }
                }

            });
            xoaHinhCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {

                HinhAnh hinh = (HinhAnh)o.SelectedItem;
                if (hinh != null)
                {
                    MessageBoxResult choice = MessageBox.Show("Bạn có muốn chuyển thông tin hình này vào thùng rác ?", "", MessageBoxButton.YesNo);
                    if (choice == MessageBoxResult.Yes)
                    {
                        if (HinhAnh_SQL.xoaDuLieu(hinh) && HinhAnhBiXoa_SQL.themDuLieu(hinh))
                        {
                            MessageBox.Show("Đã chuyển vào thùng rác !");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại !");
                        }
                    }
                    else
                    { }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hình cần chuyển vào thùng rác !");
                }
            });
            capNhatCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {
                HinhAnh hinh = (HinhAnh)o.SelectedItem;
                if (hinh != null)
                {
                    CapNhatThongTinViewModel.hinhAnh = new HinhAnh();
                    CapNhatThongTinViewModel.hinhAnh = hinh;
                    CapNhatThongTin capNhatWindow = new CapNhatThongTin();
                    #region thongTinHinhDaChon
                    ThongTinHinhDaChon.MaHinh = hinh.MaHinh;
                    ThongTinHinhDaChon.TenHinh = hinh.TenHinh;
                    ThongTinHinhDaChon.KichCo = hinh.KichCo;
                    ThongTinHinhDaChon.NgayGiaoHinh = hinh.NgayGiaoHinh;
                    ThongTinHinhDaChon.SoDienThoaiKH = hinh.SoDienThoaiKH;
                    ThongTinHinhDaChon.MaLoai = hinh.MaLoai;
                    ThongTinHinhDaChon.DaXong = hinh.DaXong;
                    ThongTinHinhDaChon.GiaHinh = hinh.GiaHinh;
                    ThongTinHinhDaChon.GiaKhachCoc = hinh.GiaKhachCoc;
                    ThongTinHinhDaChon.GhiChu = hinh.GhiChu;
                    #endregion
                    capNhatWindow.maHinhTextBlock.Text = hinh.MaHinh.ToString();
                    capNhatWindow.tenHinhTextbox.Text = hinh.TenHinh;
                    capNhatWindow.kichCoTextbox.Text = hinh.KichCo;
                    capNhatWindow.giaHinhTextbox.Text = hinh.GiaHinh.ToString();
                    capNhatWindow.tienKhachCocTextbox.Text = hinh.GiaKhachCoc.ToString();
                    capNhatWindow.ngayGiaoTextbox.Text = hinh.NgayGiaoHinh;
                    capNhatWindow.SdtTexbox.Text = hinh.SoDienThoaiKH;
                    capNhatWindow.ghiChuTextbox.Text = hinh.GhiChu;
                    capNhatWindow.ShowDialog();
 
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hình cần cập nhật thông tin !");
                }

            });
            loadCommand = new RelayCommand<ListView>((o) => { return true; },(o) => 
            {
                loadDuLieuHinhAnh(o);
            });
    
        }
        void loadDuLieuHinhAnh(ListView listView)
        {
            listHinhAnh = new ObservableCollection<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH WHERE MALOAI = " + LoaiHinhDaChon.MaLoai);
            foreach(DataRow row in dataHinhAnh.Rows)
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
                hinh.MaLoai = int.Parse(row[8].ToString());
                hinh.DaXong = int.Parse(row[7].ToString());
                listHinhAnh.Add(hinh);

            }

            listView.ItemsSource = listHinhAnh;

        }
        void loadDuLieuHinhAnh()
        {
            listHinhAnh = new ObservableCollection<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANH WHERE MALOAI = " + LoaiHinhDaChon.MaLoai);
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
                hinh.MaLoai = int.Parse(row[8].ToString());
                hinh.DaXong = int.Parse(row[7].ToString());
                listHinhAnh.Add(hinh);

            }

        }



    }
}
