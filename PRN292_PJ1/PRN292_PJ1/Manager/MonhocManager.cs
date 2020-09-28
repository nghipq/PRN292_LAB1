using PRN292_PJ1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRN292_PJ1.Manager
{
    public class MonhocManager
    {
        String filename;    //ten file
        List<Monhoc> monHocList = new List<Monhoc>();

        public MonhocManager()
        {
            this.filename = "../../../Data/txtMonHoc.txt";
            readData();
        }

        public Boolean insertMonHoc(String IDMH, String Ma_HK, String TenMH, int SoTC, int LyThuyet, int ThucHanh)
        {
            /*
                - KT IDMH exist
                - return false if IDMH exist
                - add new monhoc to monHocList
                - return true
             */
            Monhoc mh = monHocList.Find(x => x.getIDMH().Equals(IDMH));
            /*
                for(MonHoc x: monHocList) {
                    if(x.getIDMH().Equals(IDMH)) return x;
                }
             */
            if(mh != null)
            {
                return false;
            }

            mh = new Monhoc(IDMH, Ma_HK, TenMH, SoTC, LyThuyet, ThucHanh);
            monHocList.Add(mh);

            return true;
        }

        public Boolean updateMonHoc(String IDMH, String Ma_HK, String TenMH, int SoTC, int LyThuyet, int ThucHanh)
        {
            Monhoc mh = monHocList.Find(x => x.getIDMH().Equals(IDMH));

            if(mh == null)
            {
                return false;
            }

            mh.setMaHK(Ma_HK);
            mh.setTenMH(TenMH);
            mh.setSoTC(SoTC);
            mh.setLyThuyet(LyThuyet);
            mh.setThucHanh(ThucHanh);

            return true;
        }

        public void getAll()
        {
            monHocList.ForEach(x => Console.WriteLine(x.getIDMH()));
            
        }

        public Boolean readData()
        {
            StreamReader rd;
            if(!File.Exists(this.filename))
            {
                FileStream fs = File.Create(this.filename);
                rd = new StreamReader(fs, Encoding.UTF8);
            } else
            {
                rd = new StreamReader(this.filename);
            }

            String IDMH;

            IDMH = rd.ReadLine();
            while(IDMH != null)
            {
                Monhoc mh = new Monhoc();
                mh.setIDMH(IDMH);
                mh.setMaHK(rd.ReadLine());
                mh.setTenMH(rd.ReadLine());
                mh.setSoTC(Convert.ToInt32(rd.ReadLine()));
                mh.setLyThuyet(Convert.ToInt32(rd.ReadLine()));
                mh.setThucHanh(Convert.ToInt32(rd.ReadLine()));

                monHocList.Add(mh);

                IDMH = rd.ReadLine();
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
            monHocList.ForEach(x =>
            {
                tmp += x.getIDMH() + "\n";
                tmp += x.getMaHK() + "\n";
                tmp += x.getTenMH() + "\n";
                tmp += x.getSoTC() + "\n";
                tmp += x.getLyThuyet() + "\n";
                tmp += x.getThucHanh() + "\n";
            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}
