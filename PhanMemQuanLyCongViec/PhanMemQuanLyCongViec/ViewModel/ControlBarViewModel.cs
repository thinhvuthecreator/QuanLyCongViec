using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;



namespace PhanMemQuanLyCongViec.ViewModel
{
    public class ControlBarViewModel : BaseViewModel
    {
        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MoveWindowCommand { get; set; }
        #endregion

        public ControlBarViewModel()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p != null ? true : false; }, (p) => 
            { var window = ((Window)getParentWindow(p));
                if(window != null)
                {
                    window.Close();
                }
            });
            MaximizeWindowCommand = new RelayCommand<UserControl>((p) => { return p != null ? true : false; }, (p) => {
                var window = ((Window)getParentWindow(p));
                if (window != null)
                {
                    if (window.WindowState == WindowState.Maximized)
                    { window.WindowState = WindowState.Normal; }
                    else
                    {
                        window.WindowState = WindowState.Maximized;
                    }
                }
            });
            MinimizeWindowCommand = new RelayCommand<UserControl>((p) => { return p != null ? true : false; }, (p) => {
                var window = ((Window)getParentWindow(p));
                if (window != null)
                {
                    window.WindowState = WindowState.Minimized;
                }
            });
            MoveWindowCommand = new RelayCommand<UserControl>((p) => { return p != null ? true : false; }, (p) =>
            {
                var window = ((Window)getParentWindow(p));
                if (window != null)
                {
                    window.DragMove();
                }
            });
        }

        #region methods
        FrameworkElement getParentWindow(UserControl p)
        {
            FrameworkElement parent = p;
            while(parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
        #endregion

    }
}
