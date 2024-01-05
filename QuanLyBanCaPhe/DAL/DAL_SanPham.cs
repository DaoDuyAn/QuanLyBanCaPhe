using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DAL
{
    public class DAL_SanPham : DBConnect
    {
        public DataTable getAllSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham", _conn);
            DataTable dtSanPham = new DataTable();
            da.Fill(dtSanPham);
            return dtSanPham;
        }

        public DataTable getSanPhamByMaLoaiSP(int MaLoaiSP)
        {
            DataTable dtSanPham = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "select * from SanPham where MaLoaiSP = @MaLoaiSP";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSanPham);
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

            return dtSanPham;
        }

        public DataTable getSanPhamByKeyWord(string TenSanPham)
        {
            DataTable dtSanPham = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM SanPham WHERE  TenSanPham LIKE '%' + @TenSanPham + '%'";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSanPham);
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

            return dtSanPham;
        }



        public bool themSanPham(string TenSanPham, string AnhSanPham, long GiaBan, int MaLoaiSP)
        {
            try
            {
                _conn.Open();

                string SQL = "INSERT INTO SanPham(TenSanPham, AnhSanPham, GiaBan, MaLoaiSP) VALUES (@TenSanPham, @AnhSanPham, @GiaBan, @MaLoaiSP)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham);
                    cmd.Parameters.AddWithValue("@AnhSanPham", AnhSanPham);
                    cmd.Parameters.AddWithValue("@GiaBan", GiaBan);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);

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

        public bool suaSanPham(int MaSanPham, string TenSanPham, string AnhSanPham, long GiaBan, int MaLoaiSP)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("update SanPham set TenSanPham=@TenSanPham, AnhSanPham=@AnhSanPham, GiaBan=@GiaBan, MaLoaiSP=@MaLoaiSP where MaSanPham=@MaSanPham", _conn))
                {
                    cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham);
                    cmd.Parameters.AddWithValue("@AnhSanPham", AnhSanPham);
                    cmd.Parameters.AddWithValue("@GiaBan", GiaBan);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);
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

        public bool xoaSanPham(int MaSanPham)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM SanPham  WHERE MaSanPham = @MaSanPham", _conn))
                {
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
