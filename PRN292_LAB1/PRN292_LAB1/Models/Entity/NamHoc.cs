using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.Entity
{
    class NamHoc
    {
        //khai bao bien
        private String MA_NH;//ma nam hoc
        private String TEN_NH;//nam hoc
        
        /**
         * constructor
         */
        public NamHoc()
        {
        }

        /**
         * constructor
         */
        public NamHoc(string MA_NH, string TEN_NH)
        {
            MA_NH = MA_NH;
            TEN_NH = TEN_NH;
        }

        /**
         * get Ma nam hoc
         */
        public String getMA_NH()
        {
            return MA_NH;
        }

        /**
         * set ma nam hoc
         */
        public void setMA_NH()
        {
            this.MA_NH = MA_NH;
        }

        /**
         * get ten nam hoc
         */
        public String getTEN_NH()
        {
            return TEN_NH;
        }

        /**
         * set ten nam hoc
         */
        public void setTEN_NH()
        {
            this.TEN_NH = TEN_NH;
        }
    }
}
