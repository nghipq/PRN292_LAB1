using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.Entity
{
    class CTDT
    {
        private String IDMH; //Id mon hoc
        private String MaNganh; //Ma nganh
        /*
         * Tao constructor khong tham so
         */
        public CTDT()
        {

        }
        /*
         * Tao constructor voi 2 tham so
         */
        public CTDT(String IDMH, String MaNganh)
        {
            this.IDMH = IDMH;
            this.MaNganh = MaNganh;
        }
        /**
         * Lay ID Mon hoc
         */
        public String getIDMH()
        {
            return this.IDMH;
        }

        /**
         * Lay Ma Nganh
         */
        public String getMaNganh()
        {
            return this.MaNganh;
        }
        /**
        * Sua ID mon hoc
        */
        public void setIDMH(String IDMH)
        {
            this.IDMH = IDMH;
        }

        /**
         * Sua Ma Nganh
         */
        public void setMaNganh(String MaNganh)
        {
            this.MaNganh = MaNganh;
        }
    }
}
