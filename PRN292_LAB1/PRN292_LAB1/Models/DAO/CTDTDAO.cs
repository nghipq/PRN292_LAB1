using PRN292_LAB1.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace PRN292_LAB1.Models.DAO
{
    public class CTDTDAO
    {
         List<CTDT> listCTDT = new List<CTDT>();   //danh sach mon hoc
         String filename;

        public CTDTDAO()
        {
            filename = "../../../Models/Data/CTDT.txt";
            this.readfile();
        }

        /**
         * Lay danh sach mon hoc
         */
        List<CTDT> getAllCTDT()
        {
            return listCTDT;
        }
        /**
        * Them ma nganh moi
        */
        public Boolean insertMaNganh(String IDMH, String MaNganh)
        {
            CTDT ct = listCTDT.Find(x => x.getIDMH().Equals(IDMH));
            if (ct != null)
            {
                return false;
            }

            listCTDT.Add(new CTDT(IDMH, MaNganh));
            return true;
        }
        /**
        * Cap nhat ma nganh
        */
        public Boolean updateMaNganh(String IDMH, String MaNganh)
        {
            CTDT ct = listCTDT.Find(x => x.getIDMH().Equals(IDMH));
            if (ct == null)
            {
                return false;
            }
            ct.setMaNganh(MaNganh);
            return true;
        }
        /**
         * Doc file
         */
        public Boolean readfile()
        {
            //neu chua co file thi tao file
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }

            //read file
            StreamReader rd = new StreamReader(filename);

            //doc Id Mon hoc
            String IDMH = rd.ReadLine();
            //neu khong co Id Mon hoc thi ngung vong lap
            while (IDMH != null)
            {
                CTDT ct = new CTDT();
                ct.setIDMH(IDMH);
                ct.setMaNganh(rd.ReadLine());
                //add MaNganh moi vao danh sach
                listCTDT.Add((ct));
                IDMH = rd.ReadLine();
            }

            rd.Close();
            return true;
        }
        public Boolean Write()
        {
            String value = "";
            listCTDT.ForEach(x =>
            {
                value += x.getIDMH() + "\n";
                value += x.getMaNganh() + "\n";
            });
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(value);
                sw.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        /**
         * Ghi file
         */
        public Boolean writeFile()
        {
            String values = "";         //noi dung file
            listCTDT.ForEach(x =>
            {
                values += x.getIDMH() + "\n";
                values += x.getMaNganh() + "\n";
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
