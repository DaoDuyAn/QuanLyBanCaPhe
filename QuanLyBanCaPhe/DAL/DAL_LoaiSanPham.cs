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
    public class DAL_LoaiSanPham : DBConnect
    {
        public DataTable getAllLoaiSP()
        {
            DataTable dtLSanPham = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "select * from LoaiSanPham";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtLSanPham);
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

            return dtLSanPham;
        }

        public DataTable getLoaiSanPhamByKeyWord(string TenLoaiSanPham)
        {
            DataTable dtLSanPham = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT * FROM LoaiSanPham WHERE  TenLoaiSanPham LIKE '%' + @TenLoaiSanPham + '%'";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenLoaiSanPham", TenLoaiSanPham);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtLSanPham);
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

            return dtLSanPham;
        }


        public bool themLoaiSP(string TenLoaiSP)
        {
            try
            {
                _conn.Open();

                string SQL = "insert into LoaiSanPham(TenLoaiSP) values(@TenLoaiSP)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenLoaiSP", TenLoaiSP);

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

        public bool suaLoaiSP(int MaLoaiSP, string TenLoaiSP)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("update LoaiSanPham set TenLoaiSP=@TenLoaiSP where MaLoaiSP=@MaLoaiSP", _conn))
                {
                    cmd.Parameters.AddWithValue("@TenLoaiSP", TenLoaiSP);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);

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

        public bool xoaLoaiSP(int MaLoaiSP)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("delete LoaiSanPham where MaLoaiSP=@MaLoaiSP", _conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);

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
