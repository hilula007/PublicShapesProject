using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProject
{
    public class Rectangle : Point
    {
        int height;
        int width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;

            //היקף
            Circumference = width * 2 + height * 2;
            //שטח
            Area = height * width;
        }


        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
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
            return string.Format("Rectangle: Height = {0}, Width = {1}\n", height, width);

            //return string.Format("\nThis is Rectangle class:\nHeight = {0}\nWidth = {1}\nCircumference = {2}\nArea = {3}", height, width, Circumference, Area);
        }

        public override double GetArea()
        {
            return Area;
        }

        public override double GetCircumference()
        {
            return Circumference;
        }
    }
}
