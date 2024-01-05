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
    public class DAL_NhanVien : DBConnect
    {
        public DataTable getAllNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", _conn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }

        public DTO_NhanVien getNhanVienByMaNhanVien(string MaNhanVien)
        {
            DTO_NhanVien nhanVien = null;
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nhanVien = new DTO_NhanVien
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                TenNhanVien = reader["TenNhanVien"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                GioiTinh = Convert.ToBoolean(reader["GioiTinh"]),
                                MaChucVu = reader["MaChucVu"].ToString(),
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

            return nhanVien;
        }

        public DataTable getNhanVienByKeyWord(string key)
        {
            DataTable dtNhanVien = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM NhanVien WHERE TenNhanVien LIKE '%' + @TenNhanVien + '%' OR MaNhanVien LIKE '%' + @MaNhanVien + '%'";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenNhanVien", key);
                    cmd.Parameters.AddWithValue("@MaNhanVien", key);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtNhanVien);
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

            return dtNhanVien;
        }


        public bool themNhanVien(string MaNhanVien, string TenNhanVien, DateTime NgaySinh, bool GioiTinh, string MaChucVu)
        {
            try
            {
                _conn.Open();

                string SQL = "INSERT INTO NhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, MaChucVu) VALUES (@MaNhanVien, @TenNhanVien, @NgaySinh, @GioiTinh, @MaChucVu)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                    cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
                    cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);

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

        public bool suaNhanVien(string MaNhanVien, string TenNhanVien, DateTime NgaySinh, bool GioiTinh, string MaChucVu)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("update NhanVien set TenNhanVien=@TenNhanVien, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaChucVu=@MaChucVu where MaNhanVien=@MaNhanVien", _conn))
                {

                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                    cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
                    cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);

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

        public bool xoaNhanVien(string MaNhanVien)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("delete NhanVien where MaNhanVien=@MaNhanVien", _conn))
                {
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
    }
}
