using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();

        public DataTable getAllSanPham()
        {
            return dalSanPham.getAllSanPham();
        }
        public DataTable getSanPhamByMaLoaiSP(int MaLoaiSP)
        {
            return dalSanPham.getSanPhamByMaLoaiSP(MaLoaiSP);
        }
        public bool themSanPham(string TenSanPham, string AnhSanPham, long GiaBan, int MaLoaiSP)
        {
            return dalSanPham.themSanPham(TenSanPham, AnhSanPham, GiaBan, MaLoaiSP);
        }
        public bool suaSanPham(int MaSanPham, string TenSanPham, string AnhSanPham, long GiaBan, int MaLoaiSP)
        {
            return dalSanPham.suaSanPham(MaSanPham, TenSanPham, AnhSanPham, GiaBan, MaLoaiSP);
        }
        public bool xoaSanPham(int MaSanPham)
        {
            return dalSanPham.xoaSanPham(MaSanPham);
        }

        public DataTable getSanPhamByKeyWord(string TenSanPham)
        {
            return dalSanPham.getSanPhamByKeyWord(TenSanPham);
        }
    }
}
