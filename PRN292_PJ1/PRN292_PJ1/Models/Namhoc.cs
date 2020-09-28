using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Models
{
    class Namhoc
    {
        private String MA_NH;
        private String TEN_NH;

        public Namhoc()
        {
        }

        public Namhoc(String MA_NH, string TEN_NH)
        {
            this.MA_NH = MA_NH;
            this.TEN_NH = TEN_NH;
        }
        public String getMA_NH()
        {
            return this.MA_NH;
        }

        public void setMA_NH(String MA_NH)
        {
            this.MA_NH = MA_NH;
        }
        public String getTEN_NH()
        {
            return this.TEN_NH;
        }

        public void setTEN_NH(String TEN_NH)
        {
            this.TEN_NH = TEN_NH ;
        }

    }
}
