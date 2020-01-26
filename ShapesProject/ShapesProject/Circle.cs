using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProject
{
    public class Circle : Point
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
            //היקף
            Circumference = Math.PI * 2 * radius;
            //שטח
            Area = Math.PI * Math.Pow(radius, 2);
        }

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public readonly double Circumference;
        public readonly double Area;

        public override string ToString()
        {
            return string.Format("Circle: Radius = {0}\n", radius);

            //return string.Format("\nThis is Circle class:\nRadius = {0}\nCircumference = {1}\nArea = {2}", Radius, Circumference, Area);
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
