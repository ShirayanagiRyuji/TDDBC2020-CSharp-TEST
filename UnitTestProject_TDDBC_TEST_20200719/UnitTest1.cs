using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBC_TEST_20200719;

namespace UnitTestProject_TDDBC_TEST_20200719
{
    /// <summary>
    /// �����e�X�g�T���v��
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Sum���\�b�h�̃e�X�g
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Program();
            Assert.AreEqual(3, sut.Sum(1, 2));
        }
    }
}
