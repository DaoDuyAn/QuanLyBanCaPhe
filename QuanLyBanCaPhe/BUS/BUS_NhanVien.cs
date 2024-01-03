using QuanLyBanCaPhe.DAL;
using QuanLyBanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();

        public DataTable getAllNhanVien()
        {
            return dalNhanVien.getAllNhanVien();
        }
        public DTO_NhanVien getNhanVienByMaNhanVien(string MaNhanVien)
        {
            return dalNhanVien.getNhanVienByMaNhanVien(MaNhanVien);
        }
        public bool themNhanVien(string MaNhanVien, string TenNhanVien, DateTime NgaySinh, bool GioiTinh, string MaChucVu)
        {
            return dalNhanVien.themNhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, MaChucVu);
        }
        public bool suaNhanVien(string MaNhanVien, string TenNhanVien, DateTime NgaySinh, bool GioiTinh, string MaChucVu)
        {
            return dalNhanVien.suaNhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, MaChucVu);
        }
        public bool xoaNhanVien(string MaNhanVien)
        {
            return dalNhanVien.xoaNhanVien(MaNhanVien);
        }
    }
}
