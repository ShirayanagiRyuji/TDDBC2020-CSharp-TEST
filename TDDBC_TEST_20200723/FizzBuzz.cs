using System;
using System.Collections.Generic;
using System.Text;

namespace TDDBC_TEST_20200723
{
    public class FizzBuzz
    {
        /// <summary>
        /// FizzBuzzを実行するメソッド
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public string Execute(int target)
        {
            if (((target % 3) == 0)
             && ((target % 5) == 0))
            {
                return "FizzBuzz";
            }
            else if ((target % 3) == 0)
            {
                return "Fizz";
            }
            else if ((target % 5) == 0)
            {
                return "Buzz";
            }

            return Convert.ToString(target);
        }
    }
}
