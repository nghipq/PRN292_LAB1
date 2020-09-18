using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.Entity
{
    class HocKy
    {
        //Khai bao bien
        private String MA_HK;    //Ma Hoc Ky
        private String MA_NH;   //Ma Nam Hoc
        private String HK;  //Hoc ky

        //contructer rong
        public HocKy() { }
        //contructer 
        public HocKy(string MA_HK, string MA_NH, string HK)
        {
            this.MA_HK = MA_HK;
            this.MA_NH = MA_NH;
            this.HK = HK;
        }

        //get ma hoc ky
        public String getMA_HK()
        {
            return MA_HK;
        }
        //set ma hoc ky
        public void setMA_HK(String MA_HK)
        {
            this.MA_HK = MA_HK;
        }
        //get ma nam hoc
        public String getMA_NH()
        {
            return MA_NH;
        }
        //set ma nam hoc
        public void setMA_NH(String MA_NH)
        {
            this.MA_NH = MA_NH;
        }
        //get hoc ky
        public String getHK()
        {
            return HK;
        }
        //set hoc ky
        public void setHK(String HK)
        {
            this.HK = HK;
        }
    }
}