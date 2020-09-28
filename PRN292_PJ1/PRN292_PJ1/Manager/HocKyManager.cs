using PRN292_PJ1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRN292_PJ1.Manager
{
    class HocKyManager
    {
        String filename;    //ten file
        List<Hocky> HocKyList = new List<Hocky>();



        public HocKyManager()
        {
            this.filename = "../../../Data/txtHocKy.txt";
            readData();
        }

        public Boolean insertHocKy(String MA_Hk , String Ma_NH, String HK)
        {
            /*
                - KT IDMH exist
                - return false if IDMH exist
                - add new monhoc to monHocList
                - return true
             */
            Hocky hk = HocKyList.Find(x => x.getMA_Hk().Equals(MA_Hk));
            /*
                for(MonHoc x: monHocList) {
                    if(x.getIDMH().Equals(IDMH)) return x;
                }
             */
            if (hk != null)
            {
                return false;
            }

            hk = new Hocky(MA_Hk, Ma_NH , HK);
            HocKyList.Add(hk);

            return true;
        }

        public Boolean updateHocKy(String MA_Hk, String MA_NH, String HK)
        {
            Hocky hk = HocKyList.Find(x => x.getMA_Hk().Equals(MA_Hk));

            if (hk == null)
            {
                return false;
            }

            hk.setMA_NH(MA_NH);
            hk.setHK(HK);


            return true;
        }

        public void getAll()
        {
            HocKyList.ForEach(x => Console.WriteLine(x.getMA_Hk()));

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

            String MA_Hk;

            MA_Hk = rd.ReadLine();
            while (MA_Hk != null)
            {
                Hocky hk = new Hocky();
                hk.setMA_Hk(MA_Hk);
                hk.setMA_NH(rd.ReadLine());
                hk.setHK(rd.ReadLine());


                HocKyList.Add(hk);

                MA_Hk = rd.ReadLine();
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
            HocKyList.ForEach(x =>
            {
                tmp += x.getMA_Hk() + "\n";
                tmp += x.getMA_NH() + "\n";
                tmp += x.getHK() + "\n";

            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}
