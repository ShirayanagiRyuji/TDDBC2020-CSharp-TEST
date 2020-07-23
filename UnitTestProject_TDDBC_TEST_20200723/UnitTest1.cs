using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDBC_TEST_20200723;

namespace UnitTestProject_TDDBC_TEST_20200723
{
    [TestClass]
    public class UnitTest1
    {
        // �萔
        /// <summary>
        /// Fizz������
        /// </summary>
        private const string STRING_FIZZ = "Fizz";

        /// <summary>
        /// Buzz������
        /// </summary>
        private const string STRING_BUZZ = "Buzz";

        /// <summary>
        /// FizzBuzz������
        /// </summary>
        private const string STRING_FIZZBUZZ = "FizzBuzz";

        /// <summary>
        /// �e�X�g�p�C���X�^���X
        /// </summary>
        private FizzBuzz sut;


        /// <summary>
        /// �e�X�g�O�Ɏ��s���郁�\�b�h
        /// </summary>
        [TestInitialize]
        public void BeforeTest()
        {
            sut = new FizzBuzz();
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("�e�X�g�I�������I");
        }


        [DataTestMethod()]
        [DataRow(3)]
        [DataRow(6)]
        public void FizzBuzz��Execute���\�b�h��3�̔{���̐��l��n�����當����Fizz���Ԃ邱��(int target)
        {
            Assert.AreEqual(STRING_FIZZ, sut.Execute(target));
        }

        [DataTestMethod()]
        [DataRow(5)]
        [DataRow(10)]
        public void FizzBuzz��Execute���\�b�h��5�̔{���̐��l��n�����當����Fizz���Ԃ邱��(int target)
        {
            Assert.AreEqual(STRING_BUZZ, sut.Execute(target));
        }

        [DataTestMethod()]
        [DataRow(15)]
        [DataRow(30)]
        public void FizzBuzz��Execute���\�b�h��3��5�̔{���̐��l��n�����當����FizzBuzz���Ԃ邱��(int target)
        {
            Assert.AreEqual(STRING_FIZZBUZZ, sut.Execute(target));
        }

        [DataTestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        public void FizzBuzz��Execute���\�b�h��3�̔{���ł�5�̔{���ł��Ȃ����l��n������n�����l�̕����񂪕Ԃ邱��(int target)
        {
            Assert.AreEqual(Convert.ToString(target), sut.Execute(target));
        }

    }
}
