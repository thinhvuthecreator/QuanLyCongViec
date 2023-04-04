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
using PhanMemQuanLyCongViec.ViewModel;

namespace PhanMemQuanLyCongViec.View
{
    /// <summary>
    /// Interaction logic for CapNhatThongTin.xaml
    /// </summary>
    public partial class CapNhatThongTin : Window
    {
        public CapNhatThongTinViewModel capNhatVM { get; set; }
        public CapNhatThongTin()
        {
            InitializeComponent();
            this.DataContext = capNhatVM = new CapNhatThongTinViewModel();
        }
    }
}
