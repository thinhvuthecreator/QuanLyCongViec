using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PhanMemQuanLyCongViec.View;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class QuanLyHinhViewModel : BaseViewModel
    {
        #region commands
        public RelayCommand<object> addHinhCommand { get; set; }
        #endregion
        public QuanLyHinhViewModel()
        {
            addHinhCommand = new RelayCommand<object>((o) => { return true;}, (o) =>
            {
                ThemHinhView themHinhWindow = new ThemHinhView();
                themHinhWindow.ShowDialog();
            });
        }

    }
}
