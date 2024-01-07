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
    public class DAL_TaiKhoan : DBConnect
    {
        public DataTable getAllTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TaiKhoan", _conn);
            DataTable dtTaiKhoan = new DataTable();
            da.Fill(dtTaiKhoan);
            return dtTaiKhoan;
        }

        public DTO_TaiKhoan kiemTraDN(string TenDangNhap, string MatKhau)
        {
            DTO_TaiKhoan tk = null;
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tk = new DTO_TaiKhoan
                            {
                                MaTaiKhoan = reader["MaTaiKhoan"].ToString(),
                                TenDangNhap = reader["TenDangNhap"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                            };
                        }
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

            return tk;
        }

        public DataTable getTaiKhoanByKeyWord(string TenDangNhap)
        {
            DataTable dtTaiKhoan = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM TaiKhoan WHERE  TenDangNhap LIKE '%' + @TenDangNhap + '%'";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtTaiKhoan);
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

            return dtTaiKhoan;
        }

        public DTO_TaiKhoan getTKByTenDN(string TenDangNhap)
        {
            DTO_TaiKhoan tk = null;
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tk = new DTO_TaiKhoan
                            {
                                MaTaiKhoan = reader["MaTaiKhoan"].ToString(),
                                TenDangNhap = reader["TenDangNhap"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                            };
                        }
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

            return tk;
        }

        public bool doiMatKhau(string MaNhanVien, string MatKhau)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("update TaiKhoan set MatKhau=@MatKhau where MaNhanVien=@MaNhanVien", _conn))
                {
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);

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

        public bool themTaiKhoan(string MaTaiKhoan, string TenDangNhap, string MatKhau, string MaNhanVien)
        {
            try
            {
                _conn.Open();

                string SQL = "insert into TaiKhoan(MaTaiKhoan, TenDangNhap, MatKhau, MaNhanVien) values(@MaTaiKhoan, @TenDangNhap, @MatKhau, @MaNhanVien)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaTaiKhoan", MaTaiKhoan);
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
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

        public bool suaTaiKhoan(string MaTaiKhoan, string TenDangNhap, string MatKhau, string MaNhanVien)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("update TaiKhoan set TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, MaNhanVien=@MaNhanVien where MaTaiKhoan=@MaTaiKhoan", _conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                    cmd.Parameters.AddWithValue("@MaTaiKhoan", MaTaiKhoan);

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

        public bool xoaTaiKhoan(string MaTaiKhoan)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM TaiKhoan where MaTaiKhoan = @MaTaiKhoan", _conn))
                {
                    cmd.Parameters.AddWithValue("@MaTaiKhoan", MaTaiKhoan);

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
