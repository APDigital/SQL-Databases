using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeePensionManager
{
    public class ConnectionFactory
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            }
        }
    }
}