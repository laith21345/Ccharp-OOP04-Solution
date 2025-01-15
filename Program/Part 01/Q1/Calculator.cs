using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    //Q1) Write a class named Calculator that contains a method named Add.
    //    Overload the Add method to:
    //●	Accept two integers and return their sum.
    //●	Accept three integers and return their sum.
    //●	Accept two doubles and return their sum.
    internal class Calculator
    {
        #region Method
        public static long Add(int a, int b)
        {
            return a + b;
        }
        public static long Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }

        #endregion
    }
}
