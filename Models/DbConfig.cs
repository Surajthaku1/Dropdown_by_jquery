using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication53.Models
{
    public class DbConfig
    {
        public SqlConnection sql { get; }
        public DbConfig()
        {
            string cnn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sql = new SqlConnection(cnn);
        }
    }
}