using PRN292_LAB1.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PRN292_LAB1.Models.Database
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            //
            //Data Source=DESKTOP-ML331A3\KHOITHA;Initial Catalog=CinemaManagement;Integrated Security=True
            //
            string datasource = @"DESKTOP-ML331A3\KHOITHA";

            string database = "CinemaManagement";


            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
