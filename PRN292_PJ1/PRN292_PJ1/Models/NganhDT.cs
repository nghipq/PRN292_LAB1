using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Models
{
    class NganhDT
    {
        public String MaNganh { get; set; }

        public String IDBDT { get; set; }

        public String TenNganh { get; set; }

        public NganhDT()
        {
        }

        public NganhDT(string maNganh, string iDBDT, string tenNganh)
        {
            MaNganh = maNganh;
            IDBDT = iDBDT;
            TenNganh = tenNganh;
        }
    }
}
