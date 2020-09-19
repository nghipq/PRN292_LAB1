using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRN292_LAB1.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HocKyDAOTest.Tests
{
    [TestClass()]
    public class HocKyDAOTests
    {
        [TestMethod()]
        public void insertHocKyTest1()
        {
            HocKyDAO hk = new HocKyDAO();
            Boolean rs = hk.insertHocKy("1", "2", "2");

            Assert.AreEqual(false, rs);
        }

        [TestMethod()]
        public void insertHocKyTest2()
        {
            HocKyDAO hk = new HocKyDAO();
            Boolean rs = hk.insertHocKy("2", "2", "2");

            Assert.AreEqual(true, rs);
        }

        [TestMethod()]
        public void updateHocKyTest1()
        {
            HocKyDAO hk = new HocKyDAO();
            Boolean rs = hk.updateHocKy("1", "2", "2");

            Assert.AreEqual(true, rs);
        }

        [TestMethod()]
        public void updateHocKyTest2()
        {
            HocKyDAO hk = new HocKyDAO();
            Boolean rs = hk.updateHocKy("2", "2", "2");

            Assert.AreEqual(false, rs);
        }

    }
}