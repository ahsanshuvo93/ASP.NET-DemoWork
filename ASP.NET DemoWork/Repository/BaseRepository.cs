using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET_DemoWork.Repository
{
    public class BaseRepository
    {
        public SqlConnection con;
        //To Handle connection related activities      
        protected SqlConnection GetDbConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["TestDbContext"].ToString();
            con = new SqlConnection(constr);

            return con;

        }
    }
}