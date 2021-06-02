using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Version224
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This test will compile but fail to run
        /// </summary>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(1234.56)]
        public void Test224(double expected)
        {
            Assert.AreNotEqual(0d, expected);
        }

    }
}
