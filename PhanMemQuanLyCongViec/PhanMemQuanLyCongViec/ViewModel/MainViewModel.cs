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
using PhanMemQuanLyCongViec.View;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region commands
        public ICommand LoaiHinhCommand { get; set; }
        public ICommand ChuaXongCommand { get; set; }
        public ICommand DaXongCommand { get; set; }
        public ICommand ThungRacCommand { get; set; }
        #endregion
        public LoaiHinhView_ViewModel LoaiHinhVM { get; set; }
        public ChuaXongViewModel ChuaXongVM { get; set; }
        public DaXongViewModel DaXongVM { get; set; }
        public ThungRacViewModel ThungRacVM { get; set; }
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value;  
                OnPropertyChanged();        // có sự thay đổi sẽ thông báo lên view để update
            }
        }

        public MainViewModel()
        {
            
            LoaiHinhVM = new LoaiHinhView_ViewModel();
            ChuaXongVM = new ChuaXongViewModel();
            DaXongVM = new DaXongViewModel();
            ThungRacVM = new ThungRacViewModel();
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
            DaXongCommand = new RelayCommand<object>(o => { return true; }, o => 
            { CurrentView = DaXongVM; });
            ThungRacCommand = new RelayCommand<object>(o => { return true; }, o =>
            { CurrentView = ThungRacVM; });
            #endregion
            //
        }
    }
}
