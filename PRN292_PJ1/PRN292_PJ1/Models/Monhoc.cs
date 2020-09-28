using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Models
{
    class Monhoc
    {
        private String IDMH;    //id mon hoc
        private String Ma_HK;   //ma hk
        private String TenMH;   //ten mon hoc
        private int SoTC;       //so tin chi
        private int LyThuyet;   //so tiet ly thuyet
        private int ThucHanh;   //So tiet thuc hanh

        public Monhoc() { }

        public Monhoc(String IDMH, String Ma_HK, String TenMH, int SoTC, int LyThuyet, int ThucHanh)
        {
            this.IDMH = IDMH;
            this.Ma_HK = Ma_HK;
            this.TenMH = TenMH;
            this.SoTC = SoTC;
            this.LyThuyet = LyThuyet;
            this.ThucHanh = ThucHanh;
        }

        public String getIDMH()
        {
            return this.IDMH;
        }

        public void setIDMH(String IDMH)
        {
            this.IDMH = IDMH;
        }

        public String getMaHK()
        {
            return this.Ma_HK;
        }

        public void setMaHK(String Ma_HK)
        {
            this.Ma_HK = Ma_HK;
        }

        public String getTenMH()
        {
            return this.TenMH;
        }

        public void setTenMH(String TenMH)
        {
            this.TenMH = TenMH;
        }

        public int getSoTC()
        {
            return this.SoTC;
        }

        public void setSoTC(int SoTC)
        {
            this.SoTC = SoTC;
        }

        public int getLyThuyet()
        {
            return this.LyThuyet;
        }

        public void setLyThuyet(int LyThuyet)
        {
            this.LyThuyet = LyThuyet;
        }

        public int getThucHanh()
        {
            return this.ThucHanh;
        }

        public void setThucHanh(int ThucHanh)
        {
            this.ThucHanh = ThucHanh;
        }
    }
}
