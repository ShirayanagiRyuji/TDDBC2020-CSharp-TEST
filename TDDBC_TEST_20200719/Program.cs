using System;

namespace TDDBC_TEST_20200719
{
    /// <summary>
    /// 自動テストのサンプル
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 + 2 = " + new Program().Sum(1, 2).ToString());
        }

        /// <summary>
        /// 計算処理
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
