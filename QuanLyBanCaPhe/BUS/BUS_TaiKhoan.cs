using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();

        public DataTable getAllTaiKhoan()
        {
            return dalTaiKhoan.getAllTaiKhoan();
        }

        public bool themTaiKhoan(string MaTaiKhoan, string TenDangNhap, string MatKhau, string MaNhanVien)
        {
            return dalTaiKhoan.themTaiKhoan(MaTaiKhoan, TenDangNhap, MatKhau, MaNhanVien);
        }

        public bool suaTaiKhoan(string MaTaiKhoan, string TenDangNhap, string MatKhau, string MaNhanVien)
        {
            return dalTaiKhoan.suaTaiKhoan(MaTaiKhoan, TenDangNhap, MatKhau, MaNhanVien);
        }

        public bool xoaTaiKhoan(string MaTaiKhoan)
        {
            return dalTaiKhoan.xoaTaiKhoan(MaTaiKhoan);
        }
    }
}
