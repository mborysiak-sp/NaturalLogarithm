using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalLogarithm
{
    class Support
    {
        public double Power(double x, int n)
        {
            if (x == 1)
                return 1;

            if (x == -1)
                if (n % 2 == 0)
                    return 1;
                else return -1;

            if (n == 0)
                return 1;

            double halfPower = Power(x, n / 2);

            if ((n & 1) == 1)
            {
                return x * halfPower * halfPower;
            }

            return halfPower * halfPower;
        }
    }
}
//https://www.techiedelight.com/power-function-implementation-recursive-iterative/
