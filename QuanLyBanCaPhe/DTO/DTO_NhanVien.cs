using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DTO
{
    public class DTO_NhanVien
    {
        public string MaNhanVien { get; set; }  
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string MaChucVu { get; set; }
    }
}
