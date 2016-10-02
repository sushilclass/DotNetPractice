using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Areas.ProductList.DAL
{
    public class BaseDal
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        }



    }
}