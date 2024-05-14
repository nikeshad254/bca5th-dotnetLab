using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Configuration;


namespace SMS
{
    public class DBConnection
    {
        SqlConnection con;
        public DBConnection() 
        {
            con = new SqlConnection(@"Data Source=.\sqlexpress;Database=2023_BCA5TH;Integrated Security=True");
        }
        /// <summary>
        /// fetch data from database table using Sql Query
        /// </summary>
        /// <param name="query">a valid sql query</param>
        /// <returns>all data from the table [DataCollection]</returns>
        public DataTable GetData(string query)
        {
            
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                return ds.Tables.Count > 0 ? ds.Tables[0] : null;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// to execute query like create operation
        /// </summary>
        /// <param name="query">sql query</param>
        /// <returns>how many rows has been affected</returns>
        public int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
               cmd.Connection.Open();
               return cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
