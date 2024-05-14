using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace SMS_DB
{
    public class DBConnection
    {
        sq con = new SqlConnection(@"Data Source=.\sqlexpress;Database=2023_BCA5TH;Integrated Security=True");
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
    }
}
