using QuanLyBanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.BUS
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dalTK = new DAL_ThongKe();

        public DataTable getThongKeTheoNam(int Nam)
        {
            return dalTK.getThongKeTheoNam(Nam);
        }
        public DataTable getThongKeTheoNamByMaNV(int Nam, string MaNhanVien)
        {
            return dalTK.getThongKeTheoNamByMaNV(Nam, MaNhanVien);
        }
    }
}
