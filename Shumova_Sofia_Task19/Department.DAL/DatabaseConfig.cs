using Microsoft.IdentityModel.Protocols;
using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
//using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace Department.DAL
{
	public static class DatabaseConfig
	{
		public static string GetConnectionString()
		{
            //string databaseName = System.Configuration.ConfigurationManager.AppSettings["PersonAward"];

            //SqlCeConnectionStringBuilder builder = new SqlCeConnectionStringBuilder();
            //builder.DataSource = databaseName;

            //return builder.ToString();
            //string databaseName = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            //return databaseName;

            return @"Data Source=DESKTOP-HUF0F0G\SQLEXPRESS;Initial Catalog=PersonAward;Integrated Security=True";
        }
	}
}
