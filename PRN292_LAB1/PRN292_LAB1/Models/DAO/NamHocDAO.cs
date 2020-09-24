using PRN292_LAB1.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace PRN292_LAB1.Models.DAO
{
    public class NamHocDAO
    {
        List<NamHoc> listNH = new List<NamHoc>();//danh sach nam hoc
        String filename;//file stream
        public NamHocDAO()
        {
            filename = "../../../Models/Data/NamHoc.txt";//ten file
            this.readfile();

        }

        /**
         * Danh sach Nam hoc
         */
        List<NamHoc> getAllNamHoc()
        {
            return listNH;
        }

        /**
         * Them nam hoc moi
         */
        public Boolean insertNamHoc(String MA_NH, String TEN_NH)
        {
            NamHoc nh = listNH.Find(x => x.getMA_NH().Equals(MA_NH));
            if (nh != null)
            {
                return false;
            }
            listNH.Add(new NamHoc(MA_NH, TEN_NH));
            return true;
        }

        /**
         * Cap nhat nam hoc moi
         */
        public Boolean updateNamHoc(String MA_NH, String TEN_NH)
        {
            NamHoc nh = listNH.Find(x => x.getMA_NH().Equals(MA_NH));

            if(nh == null)
            {
                return false;
            }

            nh.setMA_NH(MA_NH);
            nh.setTEN_NH(TEN_NH);

            return true;
        }

        /**
         * Doc file
         */
        public Boolean readfile()
        {
            StreamReader rd;
            //neu file khong ton tai thi tao file
            if (!File.Exists(filename))
            {
                FileStream fs = File.Create(filename);
                rd = new StreamReader(fs, Encoding.UTF8);
            }
            else
            {
                //read file
                rd = new StreamReader(filename);
            }
            
            //doc MA_NH
            String MA_NH = rd.ReadLine();

            while (MA_NH != null)
            {
                String TEN_NH = rd.ReadLine();

                //them nam hoc moi
                listNH.Add(new NamHoc(MA_NH, TEN_NH));
                MA_NH = rd.ReadLine();
            }
            rd.Close();
            return true;
        }

        /**
         * ghi file
         */
        public Boolean writefile()
        {
            //noi dung file
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
