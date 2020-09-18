using PRN292_LAB1.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRN292_LAB1.Models.DAO
{
    class MonHocDAO
    {
        List<MonHoc> listMH = new List<MonHoc>();   //danh sach mon hoc
        public MonHocDAO()
        {
            String filename = "../../../Models/Data/MonHoc.txt";
            FileStream fs;

            if (File.Exists(filename))
            {
                fs = new FileStream(filename, FileMode.Open);
            }
            else
            {
                fs = File.Create(filename);
            }

            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            Console.WriteLine(rd.ReadToEnd());

            rd.Close();
        }
    }
}
