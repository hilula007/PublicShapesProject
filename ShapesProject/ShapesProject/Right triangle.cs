using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProject
{
    public class Right_triangle : Point
    {
        private int height;
        private int width;

        public Right_triangle(int height, int width)
        {
            Height = height;
            Width = width;
            
            //היקף
            Circumference = width + height + Math.Sqrt(width * width + height * height);
            //שטח
            Area = (height * width)/2;
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
            return string.Format("Right triangle: Height = {0}, Width = {1}\n", height, width);

            //return string.Format("\nThis is Right triangle class:\nHeight = {0}\nWidth = {1}\nCircumference = {2}\nArea = {3}", height, width, Circumference, Area);
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
