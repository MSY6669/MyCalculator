using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal interface ICalaulate
    {
        int plus(int num1, int num2);
        int minus(int num1, int num2);
        int zarb(int num1, int num2);
        int divide(int num1, int num2);
    }
}
