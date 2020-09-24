<<<<<<< HEAD
﻿using PRN292_LAB1.Models.DAO;
using PRN292_LAB1.Models.Database;
=======
﻿
>>>>>>> 9f13f6959d5f457ccd717ff10ef3a03624441c5d
using System;
using System.Data.SqlClient;

namespace PRN292_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
=======
            Console.WriteLine("hi");
>>>>>>> 9f13f6959d5f457ccd717ff10ef3a03624441c5d
        }
    }
}
