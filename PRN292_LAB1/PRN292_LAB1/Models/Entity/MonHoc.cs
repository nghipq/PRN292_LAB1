using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.Entity
{
    class MonHoc
    {
        //Khai bao bien
        private String IDMH;    //Id mon hoc
        private String Ma_HK;   //Ma hoc ky
        private String TenMH;  //Ten mon hoc
        private int SoTC;       //So tin chi
        private int LyThuyet;   //Ly thuyet
        private int ThucHanh;   //Thuc Hanh

        /**
         * Constructor MonHoc
         */
        public MonHoc() { }

        /**
         * Constructor MonHoc
         */
        public MonHoc(String IDMH, String Ma_HK, String TenMH, int SoTC, int LyThuyet, int ThucHanh)
        {
            this.IDMH = IDMH;
            this.Ma_HK = Ma_HK;
            this.TenMH = TenMH;
            this.SoTC = SoTC;
            this.LyThuyet = LyThuyet;
            this.ThucHanh = ThucHanh;
        }

        /**
         * Lay IDMH
         */
        public String getIDMH()
        {
            return this.IDMH;
        }

        /**
         * Lay Ma_HK
         */
        public String getMa_HK()
        {
            return this.Ma_HK;
        }

        /**
         * Lay TenMH
         */
        public String getTenMH()
        {
            return this.TenMH;
        }

        /**
         * Lay SoTC
         */
        public int getSoTC()
        {
            return this.SoTC;
        }

        /**
         * Lay LyThuyet
         */
        public int getLyThuyet()
        {
            return this.LyThuyet;
        }

        /**
         * Lay ThucHanh
         */
        public int getThucHanh()
        {
            return this.ThucHanh;
        }

        /**
         * Sua IDMH
         */
        public void setIDMH(String IDMH)
        {
            this.IDMH = IDMH;
        }

        /**
         * Sua Ma_HK
         */
        public void setMa_HK(String Ma_HK)
        {
            this.Ma_HK = Ma_HK;
        }

        /**
         * Sua TenMH
         */
        public void setTenMH(String TenMH)
        {
            this.TenMH = TenMH;
        }

        /**
         * Sua SoTC
         */
        public void setSoTC(int SoTC)
        {
            this.SoTC = SoTC;
        }

        /**
         * Sua LyThuyet
         */
        public void setLyThuyet(int LyThuyet)
        {
            this.LyThuyet = LyThuyet;
        }

        /**
         * Sua ThucHanh
         */
        public void setThucHanh(int ThucHanh)
        {
            this.ThucHanh = ThucHanh;
        }
    }
}
