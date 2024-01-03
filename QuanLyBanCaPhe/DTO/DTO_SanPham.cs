using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DTO
{
    public class DTO_SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string AnhSanPham { get; set; }
        public long GiaBan { get; set; }
        public int MaLoaiSP { get; set; }
    }
}
