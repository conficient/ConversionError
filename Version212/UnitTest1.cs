using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Version212
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This test will compile and run
        /// </summary>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(1234.56)]
        public void TestV212(double expected)
        {
            Assert.AreNotEqual(0d, expected);
        }
    }
}
