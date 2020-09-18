using PRN292_LAB1.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PRN292_LAB1.Models.DAO
{
    class HocKyDAO
    {
        private List<HocKy> listHK = new List<HocKy>(); // danh sach hoc ky
        private String filename;    // khoi tao bien fike name
        public HocKyDAO()
        {
            // ten file
            filename = "../../../Models/Data/HocKy.txt";
            this.readfile();
        }
        public List<HocKy> getAllHocKy()
        {
            return listHK;
        }
        public Boolean insertHocKy(string MA_HK, string MA_NH, string HK)
        {
            HocKy hk = listHK.Find(x => x.getMA_HK().Equals(MA_HK));
            if (hk != null)
            {
                return false;
            }
            listHK.Add(new HocKy(MA_HK, MA_NH, HK));
            return true;
        }
        public Boolean updateHocKy(string MA_HK, string MA_NH, string HK)
        {
            HocKy hk = listHK.Find(x => x.getMA_HK().Equals(MA_HK));
            hk.setMA_HK(MA_HK);
            hk.setMA_NH(MA_NH);
            hk.setHK(HK);
            return true;
        }
        public Boolean readfile()
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
            StreamReader rd = new StreamReader(filename);
            //doc Id Hoc ky
            String MA_HK = rd.ReadLine();
            //neu khong co Id hoc ky thi ngung vong lap
            while (MA_HK != null)
            {
                String Ma_HK = rd.ReadLine();
                String MA_NH = rd.ReadLine();
                String HK = rd.ReadLine();

                //add Hoc ky moi vao danh sach
                listHK.Add(new HocKy(MA_HK, MA_NH, HK));
                MA_HK = rd.ReadLine();
            }

            rd.Close();

            return true;
        }
        /**
        * Ghi file
        */
        public Boolean writeFile()
        {
            String values = "";         //noi dung file
            listHK.ForEach(x =>
            {
                values += x.getMA_HK() + "\n";
                values += x.getMA_NH() + "\n";
                values += x.getHK() + "\n";
            });

            try
            {
                StreamWriter wt = new StreamWriter(filename);
                wt.Write(values);
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