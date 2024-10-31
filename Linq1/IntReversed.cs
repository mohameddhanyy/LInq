using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    static class IntReversed
    {
        public static int Reversed(this int number)
        {
            int reversedNumber = 0, remainder;
            while (number != 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }
            return reversedNumber;
        }
    }
}
