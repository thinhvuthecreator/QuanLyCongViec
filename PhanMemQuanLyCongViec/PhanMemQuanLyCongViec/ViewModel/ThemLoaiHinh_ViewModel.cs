using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;
using PhanMemQuanLyCongViec.Model;
namespace PhanMemQuanLyCongViec.ViewModel
{
    public class ThemLoaiHinh_ViewModel : BaseViewModel
    {
        #region returnResult
        public bool isClick { get; set; }
        public string tenLoaiHinh { get; set; }
        #endregion

        #region command
        public RelayCommand<TextBox> okCommand { get; set; }
        public RelayCommand<Window> huyCommand { get; set; }
        #endregion
        public ThemLoaiHinh_ViewModel()
        {
            okCommand = new RelayCommand<TextBox>((o) => { return true; }, (o) =>
            {
                if (o.Text == "")
                {
                    MessageBox.Show("Tên loại hình không được trống !");
                }
                else
                {
                    isClick = true;
                    if (LoaiHinhAnh_SQL.themDuLieu( khoiTaoLoaiHinhAnh(o.Text)) )
                    {
                        MessageBox.Show("Tạo thành công ! Vui lòng khởi động lại phần mềm để cập nhật.");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại ! Tên loại hình bị Trùng lặp !");
                    }
                    (getParentWindow(o) as Window).Close();
                    
                }
            });
            huyCommand = new RelayCommand<Window>((o) => { return true; }, (o) =>
            {
                isClick = false;
                o.Close();
            });
        }
        FrameworkElement getParentWindow(TextBox p)
        {
            FrameworkElement parent = p;
            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
        LoaiHinhAnh khoiTaoLoaiHinhAnh(string tenLoai)
        {
            LoaiHinhAnh loaiHinh = new LoaiHinhAnh();
            loaiHinh.TenLoaiHinh = tenLoai;
            return loaiHinh;
        }

    }

  
}
