using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLYCATP
{
    class ConnectDB
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dt;

        // Tạo constructor goi kết nối khi new lớp ConnectData
        public ConnectDB()
        {
            Connect();
        }

        //Khai bao chuoi ket noi CSDL
        private string strConnect = @"Data Source=.;Initial Catalog=QLTV;Integrated Security=True";
        //Kết nối
        public void Connect()
        {
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open(); // Mo ket noi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới Cơ Sở Dữ Liệu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm lấy dữ liệu từ Database theo câu lệnh sql truyền vào
        public DataTable getdata(string sql)
        {
            // Tạo dataApdapter, thực hiện câu lệnh query
            da = new SqlDataAdapter(sql, conn);
            // Đổ dữ liệu vào DataTable
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
