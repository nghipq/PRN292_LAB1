using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRN292_LAB1.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.DAO.Tests
{
    [TestClass()]
    public class NamHocDAOTests
    {
        [TestMethod()]
        public void insertNamHocTest1()
        {
            NamHocDAO nh = new NamHocDAO();
            Boolean rs = nh.insertNamHoc("1", "2019");
            Assert.AreEqual(false, rs);
        }

        [TestMethod()]
        public void insertNamHocTest2()
        {
            NamHocDAO nh = new NamHocDAO();
            Boolean rs = nh.insertNamHoc("2", "2019");
            Assert.AreEqual(true, rs);
        }

        [TestMethod()]
        public void updateNamHocTest1()
        {
            NamHocDAO nh = new NamHocDAO();
            Boolean rs = nh.updateNamHoc("1", "2019");
            Assert.AreEqual(true, rs);
        }

        [TestMethod()]
        public void updateNamHocTest2()
        {
            NamHocDAO nh = new NamHocDAO();
            Boolean rs = nh.updateNamHoc("2", "2020");
            Assert.AreEqual(false, rs);
        }
    }
}