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
        private String filename;
        public NamHocDAO()
        {
            filename = "../../../Models/Data/NamHoc.txt";
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

        public Boolean insertNamHoc(String MA_NH, String TEN_NH)
        {
            NamHoc nh = listNH.Find(x => x.getMA_NH().Equals(MA_NH));
            if(nh != null)
            {
                return false;
            }
            listNH.Add(new NamHoc(MA_NH, TEN_NH));
            return true;
        }
        public Boolean updateNamHoc(String MA_NH, String TEN_NH)
        {
            NamHoc nh = listNH.Find(x => x.getMA_NH().Equals(MA_NH));
            nh.setMA_NH(MA_NH);
            nh.setTEN_NH(TEN_NH);

            return true;
        }
        public Boolean readfile()
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }

            StreamReader rd = new StreamReader(filename);

            String MA_NH = rd.ReadLine();

            while(MA_NH != null)
            {
                String TEN_NH = rd.ReadLine();

                listNH.Add(new NamHoc(MA_NH, TEN_NH));
                MA_NH = rd.ReadLine();
            }
            rd.Close();
            return true;
        }
        public Boolean writefile()
        {
            String value = "";
            listNH.ForEach(x =>
            {
                value += x.getMA_NH() + "\n";
                value += x.getTEN_NH() + "\n";
            });

            try
            {
                StreamWriter wt = new StreamWriter(filename);
                wt.Write(value);
                wt.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
