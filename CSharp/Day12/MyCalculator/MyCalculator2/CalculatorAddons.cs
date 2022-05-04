using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;

namespace MyCalculator2
{
    public static class CalculatorAddons
    {
         public static int Subtract(this Calculator mycalc,int x, int y)
        {
            return x - y;
        }

        public static int Multiply(this Calculator mycalc, int x, int y)
        {
            return x * y;
        }

    }
}
