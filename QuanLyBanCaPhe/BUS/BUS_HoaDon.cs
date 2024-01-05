using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon = new DAL_HoaDon();

        public DataTable getAllHoaDon()
        {
            return dalHoaDon.getAllHoaDon();
        }

        public DataTable getHoaDonByMaNhanVien(string MaNhanVien)
        {
            return dalHoaDon.getHoaDonByMaNhanVien(MaNhanVien);
        }

        public int getMaxMaHoaDon()
        {
            return dalHoaDon.getMaxMaHoaDon();
        }

        public bool themHoaDon(DateTime NgayLap, string MaNhanVien)
        {
            return dalHoaDon.themHoaDon(NgayLap, MaNhanVien);
        }

        public bool suaHoaDon(int MaHoaDon, DateTime NgayLap, string MaNhanVien)
        {
            return dalHoaDon.suaHoaDon(MaHoaDon, NgayLap, MaNhanVien);
        }

        public bool xoaHoaDon(int MaHoaDon)
        {
            return dalHoaDon.xoaHoaDon(MaHoaDon);
        }
    }
}
