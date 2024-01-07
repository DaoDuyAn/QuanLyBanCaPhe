using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DAL
{
    public class DAL_ThongKe : DBConnect
    {
        public DataTable getThongKeTheoNam(int Nam)
        {
            DataTable dtTK = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "WITH Months AS (\r\n  SELECT 1 AS month\r\n  UNION SELECT 2 UNION SELECT 3 UNION SELECT 4\r\n  UNION SELECT 5 UNION SELECT 6 UNION SELECT 7 UNION SELECT 8\r\n  UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12\r\n)\r\n\r\nSELECT m.month as month,\r\n       isnull(SUM(cthd.soLuong * cthd.donGia), 0) AS doanhThu,\r\n  COUNT(DISTINCT hd.maHoaDon) AS soDonLap\r\nFROM Months m\r\nLEFT JOIN HoaDon hd ON MONTH(hd.ngayLap) = m.month AND YEAR(hd.ngayLap) = @Nam \r\nLEFT JOIN ChiTietHoaDon cthd ON hd.maHoaDon = cthd.maHoaDon\r\n\r\nGROUP BY m.month\r\nORDER BY m.month";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nam", Nam);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtTK);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return dtTK;
        }

        public DataTable getThongKeTheoNamByMaNV(int Nam, string MaNhanVien)
        {
            DataTable dtTK = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "WITH Months AS (\r\n  SELECT 1 AS month\r\n  UNION SELECT 2 UNION SELECT 3 UNION SELECT 4\r\n  UNION SELECT 5 UNION SELECT 6 UNION SELECT 7 UNION SELECT 8\r\n  UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12\r\n)\r\n\r\nSELECT m.month,\r\n       isnull(SUM(cthd.soLuong * cthd.donGia), 0) AS doanhThu,\r\n       COUNT(DISTINCT hd.maHoaDon) AS soDonLap\r\nFROM Months m\r\nLEFT JOIN HoaDon hd ON MONTH(hd.ngayLap) = m.month AND YEAR(hd.ngayLap) = @Nam AND hd.MaNhanVien = @MaNhanVien \r\nLEFT JOIN ChiTietHoaDon cthd ON hd.maHoaDon = cthd.maHoaDon\r\n\r\nGROUP BY m.month\r\nORDER BY m.month";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nam", Nam);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtTK);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return dtTK;
        }
    }
}
