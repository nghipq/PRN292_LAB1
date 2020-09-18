using PRN292_LAB1.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace PRN292_LAB1.Models.DAO
{
    class NamHocDAO
    {
        List<NamHoc> listNH = new List<NamHoc>();//danh sach nam hoc
        public NamHocDAO()
        {
            String filename = "../../../Models/Data/NamHoc.txt";
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
        public Boolean insertNamHoc(NamHoc nh)
        {

            return false;
        }
        
    }
}
