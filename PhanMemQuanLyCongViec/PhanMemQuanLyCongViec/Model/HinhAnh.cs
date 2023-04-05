using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemQuanLyCongViec.ViewModel;

namespace PhanMemQuanLyCongViec.Model
{
    public class HinhAnh  : BaseViewModel
    {
        private int maHinh;
        private string tenHinh;
        private string kichCo;
        private decimal giaHinh;
        private decimal giaKhachCoc;
        private string soDienThoaiKH;
        private string ghiChu;
        private int maLoai;
        private string ngayGiaoHinh;
        private int daXong;
        private decimal conLai;
        private string tenLoai;
        private string daXongString;

        public string TenHinh { get => tenHinh; set { tenHinh = value; OnPropertyChanged(); } }
        public string KichCo { get => kichCo; set { kichCo = value; OnPropertyChanged(); } }
        public decimal GiaHinh { get => giaHinh; set { giaHinh = value; OnPropertyChanged(); } }
        public decimal GiaKhachCoc { get => giaKhachCoc; set { giaKhachCoc = value; OnPropertyChanged(); } }
        public string SoDienThoaiKH { get => soDienThoaiKH; set { soDienThoaiKH = value; OnPropertyChanged(); } }
        
        public string GhiChu { get => ghiChu; set { ghiChu = value; OnPropertyChanged(); } }
        public int MaLoai { get => maLoai; set { maLoai = value; OnPropertyChanged(); } }
        public string NgayGiaoHinh { get => ngayGiaoHinh; set { ngayGiaoHinh = value; OnPropertyChanged(); } }
        public int MaHinh { get => maHinh; set { maHinh = value; OnPropertyChanged(); } }
        public int DaXong { get => daXong; set { daXong = value; OnPropertyChanged(); } }
        public decimal ConLai { get => conLai; set { conLai = value; OnPropertyChanged(); } }
        public string TenLoai { get => tenLoai; set { tenLoai = value; OnPropertyChanged(); } }
        public string DaXongString { get => daXongString; set { daXongString = value; OnPropertyChanged(); } }
    }
}
