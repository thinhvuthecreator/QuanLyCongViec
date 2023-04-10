﻿using PhanMemQuanLyCongViec.Model;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class ThungRacViewModel : BaseViewModel
    {
        public ObservableCollection<HinhAnh> listHinhAnh { get; set; }
        #region commands
        public RelayCommand<ListView> khoiPhucCommand { get; set; }
        public RelayCommand<ListView> xoaVinhVienCommand { get; set; }
        public RelayCommand<ListView> loadCommand { get; set; }
        #endregion
        public ThungRacViewModel()
        {
            loadDuLieuHinhAnh();
            khoiPhucCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {
                HinhAnh hinh = (HinhAnh)o.SelectedItem;
                if (hinh != null)
                {
                    MessageBoxResult choice = MessageBox.Show("Bạn có muốn khôi phục thông tin hình này ?", "", MessageBoxButton.YesNo);
                    if (choice == MessageBoxResult.Yes)
                    {
                        if (HinhAnhBiXoa_SQL.xoaDuLieu(hinh) && HinhAnh_SQL.themDuLieu(hinh))
                        {
                            MessageBox.Show("Đã khôi phục !");
                            loadDuLieuHinhAnh(o);
                        }
                        else
                        {
                            MessageBox.Show("Khôi phục thất bại !");
                        }
                    }
                    else
                    { }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hình cần khôi phục !");
                }

            });
            xoaVinhVienCommand = new RelayCommand<ListView>((o) => { return true; }, (o) =>
            {

                HinhAnh hinh = (HinhAnh)o.SelectedItem;
                if (hinh != null)
                {
                    MessageBoxResult choice = MessageBox.Show("Bạn có muốn xóa vĩnh viễn thông tin hình này ?", "", MessageBoxButton.YesNo);
                    if (choice == MessageBoxResult.Yes)
                    {
                        if (HinhAnhBiXoa_SQL.xoaDuLieu(hinh))
                        {
                            MessageBox.Show("Đã xóa vĩnh viễn !");
                            loadDuLieuHinhAnh(o);
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
                    MessageBox.Show("Vui lòng chọn hình cần xóa vĩnh viễn !");
                }
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
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANHBIXOA H,LOAIHINHANH LH WHERE H.MALOAI = LH.MALOAI");
            foreach (DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.MaHinh = int.Parse(row[0].ToString());
                hinh.KichCo = row[9].ToString();
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
            listView.ItemsSource = listHinhAnh;
        }

        void loadDuLieuHinhAnh()
        {
            listHinhAnh = new ObservableCollection<HinhAnh>();
            DataTable dataHinhAnh = SQL_Connection.Instance.ExecuteSQL("SELECT * FROM HINHANHBIXOA H,LOAIHINHANH LH WHERE H.MALOAI = LH.MALOAI");
            foreach (DataRow row in dataHinhAnh.Rows)
            {
                HinhAnh hinh = new HinhAnh();
                hinh.MaHinh = int.Parse(row[0].ToString());
                hinh.KichCo = row[9].ToString();
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
