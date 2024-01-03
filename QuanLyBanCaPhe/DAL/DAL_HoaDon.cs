using Microsoft.Data.SqlClient;
using QuanLyBanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DAL
{
    public class DAL_HoaDon : DBConnect
    {
        public DataTable getAllHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon", _conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }

        public DataTable getHoaDonByMaNhanVien(string MaNhanVien)
        {
            DataTable dtHoaDon = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM HoaDon WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtHoaDon);
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

            return dtHoaDon;
        }


        public bool themHoaDon(DateTime NgayLap, string MaNhanVien)
        {
            try
            {
                _conn.Open();

                string SQL = "INSERT INTO HoaDon(NgayLap, MaNhanVien) VALUES (@NgayLap, @MaNhanVien)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@NgayLap", NgayLap);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
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

            return false;
        }

        public bool suaHoaDon(int MaHoaDon, DateTime NgayLap, string MaNhanVien)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET NgayLap = @NgayLap, MaNhanVien = @MaNhanVien WHERE MaHoaDon = @MaHoaDon", _conn))
                {
                    cmd.Parameters.AddWithValue("@NgayLap", NgayLap);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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

            return false;
        }

        public bool xoaHoaDon(int MaHoaDon)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon", _conn))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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

            return false;
        }
    }
}
