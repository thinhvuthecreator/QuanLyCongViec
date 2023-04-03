using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyCongViec.Model
{
    public class HinhAnhBiXoa
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

        public string TenHinh { get => tenHinh; set => tenHinh = value; }
        public string KichCo { get => kichCo; set => kichCo = value; }
        public decimal GiaHinh { get => giaHinh; set => giaHinh = value; }
        public decimal GiaKhachCoc { get => giaKhachCoc; set => giaKhachCoc = value; }
        public string SoDienThoaiKH { get => soDienThoaiKH; set => soDienThoaiKH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string NgayGiaoHinh { get => ngayGiaoHinh; set => ngayGiaoHinh = value; }
        public int MaHinh { get => maHinh; set => maHinh = value; }
        public int DaXong { get => daXong; set => daXong = value; }
        public decimal ConLai { get => conLai; set => conLai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public HinhAnhBiXoa()
        {

        }
        public HinhAnhBiXoa(HinhAnh hinh)
        {
            TenHinh = hinh.TenHinh;
            KichCo = hinh.KichCo;
            GiaHinh = hinh.GiaHinh;
            GiaKhachCoc = hinh.GiaKhachCoc;
            SoDienThoaiKH = hinh.SoDienThoaiKH;
            GhiChu = hinh.GhiChu;
            MaLoai = hinh.MaLoai;
            NgayGiaoHinh = hinh.NgayGiaoHinh;
            DaXong = hinh.DaXong;
            TenLoai = hinh.TenLoai;
        }
    }
}

