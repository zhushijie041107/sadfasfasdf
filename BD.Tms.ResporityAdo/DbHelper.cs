using Microsoft.Data.SqlClient;
using System.Data;

namespace BD.Tms.ResporityAdo
{
    public class DbHelper
    {
        /// <summary>
        /// 执行SQL语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecteNonQuery(string sql, params object[] parameters)
        {
            using (SqlConnection conn = new SqlConnection("Server=.;Database=BD_Tms;User Id=sa;Password=123456;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    if (parameters!= null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
            }
        }
        /// <summary>
        /// 执行SQL语句，返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, params object[] parameters)
        {
            using (SqlConnection conn = new SqlConnection("Server=.;Database=BD_Tms;User Id=sa;Password=123456;Encrypt=false;"))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
