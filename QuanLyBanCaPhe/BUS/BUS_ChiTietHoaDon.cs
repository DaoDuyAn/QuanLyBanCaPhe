using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dalCTHD = new DAL_ChiTietHoaDon();

        public DataTable getCTHD(int MaHoaDon)
        {
            return dalCTHD.getCTHD(MaHoaDon);
        }

        public bool themCTHD(int MaHoaDon, int MaSanPham, int SoLuong, long DonGia)
        {
            return dalCTHD.themCTHD(MaHoaDon, MaSanPham, SoLuong, DonGia);
        }

        public bool suaCTHD(int MaHoaDon, int MaSanPham, int SoLuong, long DonGia)
        {
            return dalCTHD.suaCTHD(MaHoaDon, MaSanPham, SoLuong, DonGia);
        }

        public bool xoaCTHD(int MaHoaDon, int MaSanPham)
        {
            return dalCTHD.xoaCTHD(MaHoaDon, MaSanPham);
        }
    }
}
