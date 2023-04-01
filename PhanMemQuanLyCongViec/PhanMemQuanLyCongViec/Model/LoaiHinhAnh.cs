using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyCongViec.Model
{
    public class LoaiHinhAnh
    {
        private int maLoaiHinh;
        private string tenLoaiHinh;

        public int MaLoaiHinh { get => maLoaiHinh; set => maLoaiHinh = value; }
        public string TenLoaiHinh { get => tenLoaiHinh; set => tenLoaiHinh = value; }
    }
}
