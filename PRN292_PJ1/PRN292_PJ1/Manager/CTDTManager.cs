using PRN292_PJ1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRN292_PJ1.Manager
{
    class CTDTManager
    {
        String filename;    //ten file
        List<CTDT> CTDTlist = new List<CTDT>();

        public CTDTManager()
        {
            this.filename = "../../../Data/txtCTDT.txt";
        }

        public Boolean insertMaNganh(String IDMH, String MaNganh)
        {
            /*
                - KT IDMH exist
                - return false if IDMH exist
                - add new monhoc to monHocList
                - return true
             */
            CTDT ct = CTDTlist.Find(x => x.getIDMH().Equals(IDMH));
            /*
                for(MonHoc x: monHocList) {
                    if(x.getIDMH().Equals(IDMH)) return x;
                }
             */
            if (ct != null)
            {
                return false;
            }

            ct = new CTDT(IDMH, MaNganh);
            CTDTlist.Add(ct);

            return true;
        }

        public Boolean updateMaNganh(String IDMH, String MaNganh)
        {
            CTDT ct = CTDTlist.Find(x => x.getIDMH().Equals(IDMH));

            if (ct == null)
            {
                return false;
            }
            ct.setMaNganh(MaNganh);                
            return true;
        }

        List<CTDT> getAll()
        {
            return CTDTlist;
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

            String IDMH;

            IDMH = rd.ReadLine();
            while (IDMH != null)
            {
                CTDT ct = new CTDT();
                ct.setIDMH(IDMH);
                ct.setMaNganh(rd.ReadLine());
              
                CTDTlist.Add(ct);

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
            CTDTlist.ForEach(x =>
            {
                tmp += x.getIDMH() + "\n";
                tmp += x.getMaNganh() + "\n";
              
              
            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}
