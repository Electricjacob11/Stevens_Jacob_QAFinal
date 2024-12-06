using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenZTests
{
    [TestClass]
    public class IsGenZTests
    {
        [TestMethod]
        public void Test_Year1996_ReturnsFalse()
        {
            Assert.IsFalse(GenZHelper.IsGenZ(1996));
        }

        [TestMethod]
        public void Test_Year1997_ReturnsTrue()
        {
            Assert.IsTrue(GenZHelper.IsGenZ(1997));
        }

        [TestMethod]
        public void Test_Year1998_ReturnsTrue()
        {
            Assert.IsTrue(GenZHelper.IsGenZ(1998));
        }

        [TestMethod]
        public void Test_Year2014_ReturnsTrue()
        {
            Assert.IsTrue(GenZHelper.IsGenZ(2014));
        }

        [TestMethod]
        public void Test_Year2015_ReturnsTrue()
        {
            Assert.IsTrue(GenZHelper.IsGenZ(2015));
        }

        [TestMethod]
        public void Test_Year2016_ReturnsFalse()
        {
            Assert.IsFalse(GenZHelper.IsGenZ(2016));
        }

        [TestMethod]
        [ExpectedException(typeof(IllegalArgumentException))]
        public void Test_Year0_ThrowsException()
        {
            GenZHelper.IsGenZ(0);
        }

        [TestMethod]
        [ExpectedException(typeof(IllegalArgumentException))]
        public void Test_YearNegative_ThrowsException()
        {
            GenZHelper.IsGenZ(-1);
        }

        [TestMethod]
        public void Test_Year2023_ReturnsFalse()
        {
            Assert.IsFalse(GenZHelper.IsGenZ(2023));
        }

        [TestMethod]
        public void Test_Year1500_ReturnsFalse()
        {
            Assert.IsFalse(GenZHelper.IsGenZ(1500));
        }

        [TestMethod]
        public void Test_Year10000_ReturnsFalse()
        {
            Assert.IsFalse(GenZHelper.IsGenZ(10000));
        }

        [TestMethod]
        public void Test_Year2013_ReturnsTrue()
        {
            Assert.IsTrue(GenZHelper.IsGenZ(2013));
        }

        [TestMethod]
        public void Test_Year1995_ReturnsFalse()
        {
            Assert.IsFalse(GenZHelper.IsGenZ(1995));
        }
    }
}
