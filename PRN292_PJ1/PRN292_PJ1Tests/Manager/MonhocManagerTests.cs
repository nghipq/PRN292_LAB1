using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRN292_PJ1.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_PJ1.Manager.Tests
{
    [TestClass()]
    public class MonhocManagerTests
    {

        [TestMethod()]
        public void insertMonHocTest1()
        {
            MonhocManager mm = new MonhocManager();
            Assert.AreEqual(false, mm.insertMonHoc("PRN292", "FA20", "java", 3, 3, 3));
        }

        [TestMethod()]
        public void insertMonHocTest2()
        {
            MonhocManager mm = new MonhocManager();
            Assert.AreEqual(true, mm.insertMonHoc("PRJ321", "FA20", "java", 3, 3, 3));
        }
    }
}