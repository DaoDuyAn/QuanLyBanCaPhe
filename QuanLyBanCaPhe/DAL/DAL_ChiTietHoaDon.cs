using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DAL
{
    public class DAL_ChiTietHoaDon : DBConnect
    {
        public DataTable getCTHD(int MaHoaDon)
        {
            DataTable dtHoaDon = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);

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

        public bool themCTHD(int MaHoaDon, int MaSanPham, int SoLuong, long DonGia)
        {
            try
            {
                _conn.Open();

                string SQL = "INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong, DonGia) VALUES (@MaHoaDon, @MaSanPham, @SoLuong, @DonGia)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                    cmd.Parameters.AddWithValue("@DonGia", DonGia);

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

        public bool suaCTHD(int MaHoaDon, int MaSanPham, int SoLuong, long DonGia)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE ChiTietHoaDon SET MaSanPham=@MaSanPham, SoLuong=@SoLuong, DonGia=@DonGia WHERE MaHoaDon = @MaHoaDon", _conn))
                {

                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                    cmd.Parameters.AddWithValue("@DonGia", DonGia);
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

        public bool xoaCTHD(int MaHoaDon, int MaSanPham)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("delete ChiTietHoaDon where MaHoaDon=@MaHoaDon and MaSanPham=@MaSanPham", _conn))
                {


                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);

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
