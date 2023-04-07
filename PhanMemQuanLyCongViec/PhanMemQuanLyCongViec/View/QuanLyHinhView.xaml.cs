using System;
using System.Collections.Generic;
using System.Data;
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
using PhanMemQuanLyCongViec.Model;
using PhanMemQuanLyCongViec.ViewModel;
using PhanMemQuanLyCongViec.ViewModel.SQL_ThaoTac;

namespace PhanMemQuanLyCongViec.View
{
    /// <summary>
    /// Interaction logic for QuanLyHinhView.xaml
    /// </summary>
    public partial class QuanLyHinhView : Window
    {
        QuanLyHinhViewModel quanLyHinhVM { get; set; }
        public QuanLyHinhView()
        {
            InitializeComponent();
            this.DataContext = quanLyHinhVM = new QuanLyHinhViewModel();
        }

    
    }
}
