using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    //Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
    // * Note: Overload the +, - operator to add and subtract two complex numbers. 

    internal class ComplexNumber
    {
        #region Properties
        public double Real { get; set; }
        public double Image { get; set; }
        #endregion

        #region Method
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Image = (left?.Image ?? 0) + (right?.Image ?? 0)
            };
        }
        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Image = (left?.Image ?? 0) - (right?.Image ?? 0)
            };
        }
        public override string ToString()
        {
            return $"Real ={Real}, Image ={Image}";
        }
        #endregion
    }
}
