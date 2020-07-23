using System;

namespace TDDBC_TEST_20200723
{
    class Program
    {
        /// <summary>
        /// FizzBuzzする
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var fb = new FizzBuzz();

            for (int val = 1; val <= 50; val++)
            {
                Console.WriteLine(fb.Execute(val));
            }
        }
    }
}
