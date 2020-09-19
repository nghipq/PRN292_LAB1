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
        public void MonHocDAOTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void insertMonHocTest()
        {
            MonHocDAO md = new MonHocDAO();
            try
            {
                md.insertMonHoc()
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void updateMonHocTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void readfileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void writeFileTest()
        {
            Assert.Fail();
        }
    }
}