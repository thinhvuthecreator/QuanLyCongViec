using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PhanMemQuanLyCongViec.View;
using PhanMemQuanLyCongViec.Model;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using System.Data;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class LoaiHinhView_ViewModel : BaseViewModel
    {
        #region commands
        public RelayCommand<object> themLoaiHinhCommand { get; set; }
        public RelayCommand<WrapPanel> viewLoadCommand { get; set; }
        #endregion
        public LoaiHinhView_ViewModel()
        {
           
            themLoaiHinhCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThemLoaiHinhView windowThem = new ThemLoaiHinhView();
                windowThem.ShowDialog();
            });
            viewLoadCommand = new RelayCommand<WrapPanel>((p) => { return true; }, (p) =>   //p là WrapPanel
            {
                loadDuLieuCacLoaiHinh(p); 
            });

        }

        #region methods
        void loadDuLieuCacLoaiHinh(WrapPanel p)
        {
            
            DataTable dataLoaiHinh = LoaiHinhAnh_SQL.loadDulieu(); // trả về tất cả các loại hình
            foreach(DataRow row in dataLoaiHinh.Rows)
            {
                if (row != null)
                {
                    Button loaiHinhBtn = new Button();
                    loaiHinhBtn.Width = 180;
                    loaiHinhBtn.Height = 150;
                    Thickness margin = loaiHinhBtn.Margin;
                    margin.Left = 20;
                    margin.Right = 20;
                    margin.Top = 20;
                    margin.Bottom = 20;
                    loaiHinhBtn.Margin = margin;
                    var bc = new BrushConverter();
                    loaiHinhBtn.Background = (Brush)bc.ConvertFrom("#FF3E4E5F");
                    loaiHinhBtn.Content = row[1].ToString();    // tên loại hình
                    loaiHinhBtn.MouseEnter += LoaiHinhBtn_MouseEnter;
                    loaiHinhBtn.MouseLeave += LoaiHinhBtn_MouseLeave;
                    loaiHinhBtn.Click += LoaiHinhBtn_Click;
                    p.Children.Add(loaiHinhBtn);


                }
                else { }
            }




           

        }
        #endregion

        #region events
        private void LoaiHinhBtn_Click(object sender, RoutedEventArgs e)
        {
            QuanLyHinhView quanLyHinhWindow = new QuanLyHinhView();
            quanLyHinhWindow.ShowDialog();
        }
        private void LoaiHinhBtn_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button thisBtn = sender as Button;
            var bc = new BrushConverter();
            thisBtn.Background = (Brush)bc.ConvertFrom("#FF3E4E5F");
            thisBtn.Foreground = (Brush)bc.ConvertFrom("White");
        }
        private void LoaiHinhBtn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button thisBtn = sender as Button;
            var bc = new BrushConverter();
            thisBtn.Background = (Brush)bc.ConvertFrom("#FFE3FFFE");
            thisBtn.Foreground = (Brush)bc.ConvertFrom("#FF080808");
        }
        #endregion

    }
}
