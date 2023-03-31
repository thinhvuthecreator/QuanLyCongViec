using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region commands
        public ICommand LoaiHinhCommand { get; set; }
        public ICommand ChuaXongCommand { get; set; }
        #endregion
        public LoaiHinhViewModel LoaiHinhVM { get; set; }
        public ChuaXongViewModel ChuaXongVM { get; set; }
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value;  
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {

            LoaiHinhVM = new LoaiHinhViewModel();
            ChuaXongVM = new ChuaXongViewModel();
            CurrentView = LoaiHinhVM;

            #region commands
            LoaiHinhCommand = new RelayCommand<object>(o => { return true; },o =>
            {
                CurrentView = LoaiHinhVM;
            });
            ChuaXongCommand = new RelayCommand<object>(o => { return true; },o =>
            {
                CurrentView = ChuaXongVM;
            });
            #endregion


            //LoginWindow loginWD = new LoginWindow();
            //if (!isActivated)
            //{
            //    isActivated = true;

            //    loginWD.ShowDialog();
            //}
        }
    }
}
