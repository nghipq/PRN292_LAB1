using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRN292_LAB1.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_LAB1.Models.DAO.Tests
{
    [TestClass()]
    public class CTDTDAOTests
    {
        [TestMethod()]
        public void CTDTDAOTestInsertMaNganh1()
        {
            CTDTDAO ctdao = new CTDTDAO();
            Boolean rs = ctdao.insertMaNganh("2","IT");
            Assert.AreEqual(true, rs);
        }
        [TestMethod()]
        public void CTDTDAOTestInsertMaNganh2()
        {
            CTDTDAO ctdao = new CTDTDAO();
            Boolean rs = ctdao.insertMaNganh("1", "1");
            Assert.AreEqual(false, rs);
        }
        [TestMethod()]
        public void CTDTDAOTestUpdateMaNganh1()
        {
            CTDTDAO ctdao = new CTDTDAO();
            Boolean rs = ctdao.updateMaNganh("1", "Business");
            Assert.AreEqual(true, rs);
        }
        [TestMethod()]
        public void CTDTDAOTestUpdateMaNganh2()
        {
            CTDTDAO ctdao = new CTDTDAO();
            Boolean rs = ctdao.updateMaNganh("0", "Business");
            Assert.AreEqual(false, rs);
        }
    }
}