using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dalLoaiSP = new DAL_LoaiSanPham();

        public DataTable getAllLoaiSP()
        {
            return dalLoaiSP.getAllLoaiSP();
        }

        public DataTable getLoaiSanPhamByKeyWord(string TenLoaiSanPham)
        {
            return dalLoaiSP.getLoaiSanPhamByKeyWord(TenLoaiSanPham);
        }

        public bool themLoaiSP(string TenLoaiSP)
        {
            return dalLoaiSP.themLoaiSP(TenLoaiSP);
        }

        public bool suaLoaiSP(int MaLoaiSP, string TenLoaiSP)
        {
            return dalLoaiSP.suaLoaiSP(MaLoaiSP, TenLoaiSP);
        }

        public bool xoaLoaiSP(int MaLoaiSP)
        {
            return dalLoaiSP.xoaLoaiSP(MaLoaiSP);
        }
    }
}
