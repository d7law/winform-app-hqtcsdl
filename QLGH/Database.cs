using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGH
{
    public class Database
    {
        // chuỗi kết nối db
        private string connetionString = "Data source=localhost;Initial Catalog = QLGH_SHOPEE; User ID = sa; Password=hykln123";
        string role = RoleState.role;


        private SqlConnection conn;


        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                //SQL-SERVER Auth
                /*if (role == "Admin")
                    connetionString = "Data source=localhost;Initial Catalog = QLGH_SHOPEE; User ID = SHOPEE_Admin; Password=admin123";
                else connetionString = "Data source=localhost;Initial Catalog = QLGH_SHOPEE; User ID = SHOPEE_User; Password=hykln123";*/
                conn = new SqlConnection(connetionString);

            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }
        public Boolean DangKy(string tenKH, string email, string sdt, string gioiTinh, string diaChi, string tenDN, string mk)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SignUp_KhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                List<SqlParameter> prm = new List<SqlParameter>()
                {
                    new SqlParameter("@TenKH", SqlDbType.VarChar){Value = tenKH},
                    new SqlParameter("@Email", SqlDbType.VarChar){Value = email},
                    new SqlParameter("@SDT", SqlDbType.VarChar){Value = sdt },
                    new SqlParameter("@GioiTinh", SqlDbType.VarChar){Value = gioiTinh},
                    new SqlParameter("@DiaChi", SqlDbType.VarChar){Value = diaChi},
                    new SqlParameter("@TenDangNhap", SqlDbType.VarChar){Value = tenDN},
                    new SqlParameter("@MatKhau", SqlDbType.VarChar){Value = mk},
                };
                cmd.Parameters.AddRange(prm.ToArray());
                var rs = cmd.ExecuteReader();
                if (rs.RecordsAffected != -1) return true;
                return false;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Loi");
                return false;
            }
            finally { conn.Close(); }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn); // nội dung sql đc truyền
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn); // nội dung sql đc truyền
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn); // nội dung sql đc truyền
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện câu lệnh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
