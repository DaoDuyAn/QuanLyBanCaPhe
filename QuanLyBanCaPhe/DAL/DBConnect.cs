using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCaPhe.DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Server=DESKTOP-32ITQVJ\\SQLEXPRESS;Database=QuanLyBanCaPhe;User ID=sa;Password=andao882001;TrustServerCertificate=True");
    }
}
