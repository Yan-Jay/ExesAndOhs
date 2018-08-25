using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExesAndOhs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void XoTest()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
        }
        [TestMethod()]
        public void XoTest2()
        {
            Assert.AreEqual(true, Kata.XO("xxOo"));
        }
        [TestMethod()]
        public void XoTest3()
        {
            Assert.AreEqual(false, Kata.XO("xxxm"));
        }
        [TestMethod()]
        public void XoTest4()
        {
            Assert.AreEqual(false, Kata.XO("Oo"));
        }
        [TestMethod()]
        public void XoTest5()
        {
            Assert.AreEqual(false, Kata.XO("ooom"));
        }
    }
}