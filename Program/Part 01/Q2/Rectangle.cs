using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    //Q2) Create a class named Rectangle with the following constructors:
    //●	A parameterless constructor that sets the width and height to 0.
    //●	A constructor that accepts width and height as integers.
    //●	A constructor that accepts a single integer and sets both width and height to that value.
    internal class Rectangle
    {
        #region Properties
        public float Height { get; set; }
        public float Width { get; set; }
        #endregion

        #region Constractors
        public Rectangle()
        {
            Height = Width = 0;
        }
        public Rectangle(int height, int width)
        {
            Height = Convert.ToSingle(height);
            Width = Convert.ToSingle(width);
        }
        public Rectangle(int value)
        {
            Height = Width = value;
        }
        #endregion
    }
}
