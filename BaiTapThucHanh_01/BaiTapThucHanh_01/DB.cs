using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanh_01
{
    public static class DB
    {
        public const string ConnectionString =
            "Data Source=DESKTOP-REV9Q12;Initial Catalog=formSinhvien;Integrated Security=True";

        public static SqlConnection Connection = new SqlConnection(ConnectionString);
    }
}
