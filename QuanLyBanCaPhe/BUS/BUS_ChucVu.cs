using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dalChucVu = new DAL_ChucVu();

        public DataTable getAllChucVu()
        {
            return dalChucVu.getAllChucVu();
        }

        public bool themChucVu(string MaChucVu, string TenChucVu)
        {
            return dalChucVu.themChucVu(MaChucVu, TenChucVu);
        }

        public bool suaChucVu(string MaChucVu, string TenChucVu)
        {
            return dalChucVu.suaChucVu(MaChucVu, TenChucVu);
        }

        public bool xoaChucVu(string MaChucVu)
        {
            return dalChucVu.xoaChucVu(MaChucVu);
        }

    }
}
