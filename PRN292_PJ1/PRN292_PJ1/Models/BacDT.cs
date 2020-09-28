using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Models
{
    class BacDT
    {
        public String IDBDT { get; set; }

        public String TenBDT { get; set; }

        public BacDT()
        {
        }

        public BacDT(string iDBDT, string tenBDT)
        {
            IDBDT = iDBDT;
            TenBDT = tenBDT;
        }
    }
}
