using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Models
{
    class Hocky
    {
        private String MA_Hk;
        private String MA_NH;
        private String HK;

        public Hocky()
        {
        }

        public Hocky(String MA_Hk, string Ma_NH, String HK)
        {
            this.MA_Hk = MA_Hk;
            this.MA_NH = MA_NH;
            this.HK = HK;
        }
        public String getMA_Hk()
        {
            return this.MA_Hk;
        }

        public void setMA_Hk(String MA_Hk)
        {
            this.MA_Hk = MA_Hk;
        }
        public String getMA_NH()
        {
            return this.MA_NH;
        }

        public void setMA_NH(String MA_NH)
        {
            this.MA_NH = MA_NH;
        }
        public String getHK()
        {
            return this.HK;
        }

        public void setHK(String HK)
        {
            this.HK = HK;
        }

    }
}
