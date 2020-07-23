using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBC_TEST_20200719;

namespace UnitTestProject_TDDBC_TEST_20200719
{
    /// <summary>
    /// 自動テストサンプル
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Sumメソッドのテスト
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Program();
            Assert.AreEqual(3, sut.Sum(1, 2));
        }
    }
}
