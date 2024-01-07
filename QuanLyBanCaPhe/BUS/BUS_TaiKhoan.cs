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
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();

        public DataTable getAllTaiKhoan()
        {
            return dalTaiKhoan.getAllTaiKhoan();
        }

        public DataTable getTaiKhoanByKeyWord(string TenDangNhap)
        {
            return dalTaiKhoan.getTaiKhoanByKeyWord(TenDangNhap);
        }

        public DTO_TaiKhoan kiemTraDN(string TenDangNhap, string MatKhau)
        {
            return dalTaiKhoan.kiemTraDN(TenDangNhap, MatKhau);
        }

        public DTO_TaiKhoan getTKByTenDN(string TenDangNhap)
        {
            return dalTaiKhoan.getTKByTenDN(TenDangNhap);
        }

        public bool doiMatKhau(string MaNhanVien, string MatKhau)
        {
            return dalTaiKhoan.doiMatKhau(MaNhanVien, MatKhau);
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
