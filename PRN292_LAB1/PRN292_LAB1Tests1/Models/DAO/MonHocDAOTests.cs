using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRN292_LAB1.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.DAO.Tests
{
    [TestClass()]
    public class MonHocDAOTests
    {
        [TestMethod()]
        public void insertMonHocTest1()
        {
            MonHocDAO md = new MonHocDAO();
            Boolean rs = md.insertMonHoc("1", "2", "2", 2, 2, 2);

            Assert.AreEqual(false, rs);
        }

        [TestMethod()]
        public void insertMonHocTest2()
        {
            MonHocDAO md = new MonHocDAO();
            Boolean rs = md.insertMonHoc("2", "2", "2", 2, 2, 2);

            Assert.AreEqual(true, rs);
        }

        [TestMethod()]
        public void updateMonHocTest1()
        {
            MonHocDAO md = new MonHocDAO();
            Boolean rs = md.updateMonHoc("1", "1", "1", 2, 2, 2);

            Assert.AreEqual(true, rs);
        }

        [TestMethod()]
        public void updateMonHocTest2()
        {
            MonHocDAO md = new MonHocDAO();
            Boolean rs = md.updateMonHoc("2", "1", "1", 2, 2, 2);

            Assert.AreEqual(false, rs);
        }
    }
}