using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProject
{
    public class Square : Point
    {
        private int width;

        public Square(int width)
        {
            Width = width;
            //היקף
            Circumference = width * 4;
            //שטח
            Area = width * width;
        }


        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }


        public readonly double Circumference;
        public readonly double Area;


        public override string ToString()
        {
            return string.Format("Square: Width = {0}\n", width);

            //return string.Format("\nThis is Square class:\nWidth = {0}\nCircumference = {1}\nArea = {2}", width, Circumference, Area);
        }


        public override Double GetArea()
        {
            return Area;
        }


        public override double GetCircumference()
        {
            return Circumference;
        }
    }
}
