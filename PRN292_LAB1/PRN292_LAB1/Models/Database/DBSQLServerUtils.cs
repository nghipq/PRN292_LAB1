using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PRN292_LAB1.Models.DAO
{
    class DBSQLServerUtils
    {
        public static SqlConnection
                  GetDBConnection(string datasource, string database)
        {
            //
            //Data Source=DESKTOP-ML331A3\KHOITHA;Initial Catalog=CinemaManagement;Integrated Security=True
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
