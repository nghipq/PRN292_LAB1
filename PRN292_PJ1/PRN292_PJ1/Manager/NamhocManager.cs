using PRN292_PJ1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRN292_PJ1.Manager
{
    class NamhocManager
    {
        String filename;    //ten file
        List<Namhoc> nhlist = new List<Namhoc>();

        public NamhocManager()
        {
            this.filename = "../../../Data/txtNamHoc.txt";
        }

        public Boolean insertMaNganh(String MA_NH, String TEN_NH)
        {
            /*
                - KT IDMH exist
                - return false if IDMH exist
                - add new monhoc to monHocList
                - return true
             */
            Namhoc nh = nhlist.Find(x => x.getMA_NH().Equals(MA_NH));
            /*
                for(MonHoc x: monHocList) {
                    if(x.getIDMH().Equals(IDMH)) return x;
                }
             */
            if (nh != null)
            {
                return false;
            }

            nh = new Namhoc(MA_NH, TEN_NH);
            nhlist.Add(nh);

            return true;
        }

        public Boolean updateNamHoc(int MA_NH, String TEN_NH)
        {
            Namhoc nh = nhlist.Find(x => x.getMA_NH().Equals(MA_NH));

            if (nh == null)
            {
                return false;
            }
            nh.setTEN_NH(TEN_NH);
            return true;
        }

        List<Namhoc> getAll()
        {
            return nhlist;
        }

        public Boolean readData()
        {
            StreamReader rd;
            if (!File.Exists(this.filename))
            {
                FileStream fs = File.Create(this.filename);
                rd = new StreamReader(fs, Encoding.UTF8);
            }
            else
            {
                rd = new StreamReader(this.filename);
            }

            String MA_NH;

            MA_NH = rd.ReadLine();
            while (MA_NH != null)
            {
                Namhoc nh = new Namhoc();
                nh.setMA_NH(MA_NH);
                nh.setTEN_NH(rd.ReadLine());


                nhlist.Add(nh);

                MA_NH = rd.ReadLine();
            }
            rd.Close();
            return true;
        }

        public Boolean writeData()
        {
            StreamWriter wt = new StreamWriter(this.filename);
            /*
                tmp = ""
                loop from monHocList
                write to tmp
                write tmp to txtMonHoc
             */
            String tmp = "";
            nhlist.ForEach(x =>
            {
                tmp += x.getMA_NH() + "\n";
                tmp += x.getTEN_NH() + "\n";


            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}

