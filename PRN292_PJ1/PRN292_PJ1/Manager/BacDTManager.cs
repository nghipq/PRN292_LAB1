using PRN292_PJ1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Manager
{
    class BacDTManager
    {
        private String filename = "../../../Data/txtCTDT.txt";
        private List<BacDT> bacDTList;

        public BacDTManager()
        {
            bacDTList = new List<BacDT>();
        }

        public bool InsertBacDT(String IDBDT, String tenBacDT)
        {
            bool existed = bacDTList.Exists(x => x.IDBDT.Equals(IDBDT));

            if(existed)
            {
                return false;
            }

            bacDTList.Add(new BacDT
            {
                IDBDT = IDBDT,
                TenBDT = tenBacDT
            });

            return true;
        }

        public void PrintBacDT()
        {
            Console.WriteLine("IDBDT\tTenBacDT");
            bacDTList.ForEach(x => Console.WriteLine(x.IDBDT + "\t" + x.TenBDT));


        }
    }
}
