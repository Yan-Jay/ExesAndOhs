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
        public void OAndXIsEqual()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
        }
        [TestMethod()]
        public void TwoOAndXIsEqual()
        {
            Assert.AreEqual(true, Kata.XO("xxOo"));
        }
        [TestMethod()]
        public void OAndXIsNotEqualandHasAnother()
        {
            Assert.AreEqual(false, Kata.XO("xxxm"));
        }
        [TestMethod()]
        public void JustTwoO()
        {
            Assert.AreEqual(false, Kata.XO("Oo"));
        }
        [TestMethod()]
        public void JustThreeOandHasAnother()
        {
            Assert.AreEqual(false, Kata.XO("ooom"));
        }
    }
}