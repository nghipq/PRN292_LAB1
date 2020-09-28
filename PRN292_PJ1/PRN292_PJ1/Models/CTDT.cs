using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Models
{
    class CTDT
    {
        private String IDMH; //Id Mon hoc
        private String MaNganh;//Ma Nganh hoc
        //Tao mot constructor khong tham so
        public CTDT() { }
        /*
         * Tao mot constructor voi 2 tham so
         */
        public CTDT(String IDMH, String MaNganh)
        {
            this.IDMH = IDMH;
            this.MaNganh = MaNganh;
           
        }

        public String getIDMH()
        {
            return this.IDMH;
        }

        public void setIDMH(String IDMH)
        {
            this.IDMH = IDMH;
        }
        public String getMaNganh()
        {
            return this.MaNganh;
        }

        public void setMaNganh(String MaNganh)
        {
            this.MaNganh = MaNganh;
        }
    }
}
