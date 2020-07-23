using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDBC_TEST_20200723;

namespace UnitTestProject_TDDBC_TEST_20200723
{
    [TestClass]
    public class UnitTest1
    {
        // 定数
        /// <summary>
        /// Fizz文字列
        /// </summary>
        private const string STRING_FIZZ = "Fizz";

        /// <summary>
        /// Buzz文字列
        /// </summary>
        private const string STRING_BUZZ = "Buzz";

        /// <summary>
        /// FizzBuzz文字列
        /// </summary>
        private const string STRING_FIZZBUZZ = "FizzBuzz";

        /// <summary>
        /// テスト用インスタンス
        /// </summary>
        private FizzBuzz sut;


        /// <summary>
        /// テスト前に実行するメソッド
        /// </summary>
        [TestInitialize]
        public void BeforeTest()
        {
            sut = new FizzBuzz();
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("テスト終わったよ！");
        }


        [DataTestMethod()]
        [DataRow(3)]
        [DataRow(6)]
        public void FizzBuzzのExecuteメソッドに3の倍数の数値を渡したら文字列Fizzが返ること(int target)
        {
            Assert.AreEqual(STRING_FIZZ, sut.Execute(target));
        }

        [DataTestMethod()]
        [DataRow(5)]
        [DataRow(10)]
        public void FizzBuzzのExecuteメソッドに5の倍数の数値を渡したら文字列Fizzが返ること(int target)
        {
            Assert.AreEqual(STRING_BUZZ, sut.Execute(target));
        }

        [DataTestMethod()]
        [DataRow(15)]
        [DataRow(30)]
        public void FizzBuzzのExecuteメソッドに3と5の倍数の数値を渡したら文字列FizzBuzzが返ること(int target)
        {
            Assert.AreEqual(STRING_FIZZBUZZ, sut.Execute(target));
        }

        [DataTestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        public void FizzBuzzのExecuteメソッドに3の倍数でも5の倍数でもない数値を渡したら渡した値の文字列が返ること(int target)
        {
            Assert.AreEqual(Convert.ToString(target), sut.Execute(target));
        }

    }
}
