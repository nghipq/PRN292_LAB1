using PRN292_LAB1.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRN292_LAB1.Models.DAO
{
    public class MonHocDAO
    {
        List<MonHoc> listMH = new List<MonHoc>();   //danh sach mon hoc
        String filename;                            //filestream
        public MonHocDAO()
        {
            //ten file
            filename = "../../../Models/Data/MonHoc.txt";
            this.readfile();
        }

        /**
         * Lay danh sach mon hoc
         */
        List<MonHoc> getAllMonHoc()
        {
            return listMH;
        }

        /**
         * Them mon hoc moi
         */
        public Boolean insertMonHoc(String IDMH, String Ma_HK, String TenMH, int SoTC, int LyThuyet, int ThucHanh)
        {
            //Tim xem ma mon hoc da ton tai hay chua
            MonHoc mh = listMH.Find(x => x.getIDMH().Equals(IDMH));
            //neu ma mon hoc ton tai --> tra ve false
            if (mh != null)
            {
                return false;
            }

            //add mon hoc vao mang
            listMH.Add(new MonHoc(IDMH, Ma_HK, TenMH, SoTC, LyThuyet, ThucHanh));
            return true;
        }

        /**
         * Cap nhat mon hoc
         */
        public Boolean updateMonHoc(String IDMH, String Ma_HK, String TenMH, int SoTC, int LyThuyet, int ThucHanh)
        {
            MonHoc mh = listMH.Find(x => x.getIDMH().Equals(IDMH));

            if (mh == null)
            {
                return false;
            }

            mh.setMa_HK(Ma_HK);
            mh.setTenMH(TenMH);
            mh.setSoTC(SoTC);
            mh.setLyThuyet(LyThuyet);
            mh.setThucHanh(ThucHanh);

            return true;
        }

        /**
         * Doc file
         */
        public Boolean readfile()
        {
            StreamReader rd;
            //neu chua co file thi tao file
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

            //doc Id Mon hoc
            String IDMH = rd.ReadLine();
            //neu khong co Id Mon hoc thi ngung vong lap
            while (IDMH != null)
            {
                String Ma_HK = rd.ReadLine();
                String TenMH = rd.ReadLine();
                int SoTC = Convert.ToInt32(rd.ReadLine());
                int LyThuyet = Convert.ToInt32(rd.ReadLine());
                int ThucHanh = Convert.ToInt32(rd.ReadLine());

                //add MonHoc moi vao danh sach
                listMH.Add(new MonHoc(IDMH, Ma_HK, TenMH, SoTC, LyThuyet, ThucHanh));
                IDMH = rd.ReadLine();
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
            listMH.ForEach(x =>
            {
                values += x.getIDMH() + "\n";
                values += x.getMa_HK() + "\n";
                values += x.getTenMH() + "\n";
                values += x.getSoTC() + "\n";
                values += x.getLyThuyet() + "\n";
                values += x.getThucHanh() + "\n";
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
