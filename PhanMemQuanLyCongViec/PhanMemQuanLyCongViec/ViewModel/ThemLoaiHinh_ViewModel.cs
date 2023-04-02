using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
                    tenLoaiHinh = o.Text;
                    MessageBox.Show("Tạo thành công !");
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

    }

  
}
