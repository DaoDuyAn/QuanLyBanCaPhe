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
    public class DAL_ChucVu : DBConnect
    {
        public DataTable getAllChucVu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", _conn);
            DataTable dtChucVu = new DataTable();
            da.Fill(dtChucVu);
            return dtChucVu;
        }

        public bool themChucVu(string MaChucVu, string TenChucVu)
        {
            try
            {
                _conn.Open();

                string SQL = "INSERT INTO ChucVu(MaChucVu, TenChucVu) VALUES (@MaChucVu, @TenChucVu)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);
                    cmd.Parameters.AddWithValue("@TenChucVu", TenChucVu);

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

        public bool suaChucVu(string MaChucVu, string TenChucVu)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE ChucVu SET TenChucVu = @TenChucVu WHERE MaChucVu = @MaChucVu", _conn))
                {
                    cmd.Parameters.AddWithValue("@TenChucVu", TenChucVu);
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

        public bool xoaChucVu(string MaChucVu)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM ChucVu WHERE MaChucVu = @MaChucVu", _conn))
                {


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
    }
}
