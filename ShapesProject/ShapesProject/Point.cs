using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProject
{
   public class Point : Shape
    {
        private int u;
        private int v;

        public Point(int u, int v)
        {
            U = u;
            V = v;
        }

        public Point()
        {

        }

        public int U
        {
            get
            {
                return u;
            }

            set
            {
                u = value;
            }
        }

        public int V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\nThis is point class:\n Point u = {0} and Point v = {1}", U, V);
        }


        public override double GetArea()
        {
            return 0;
        }


        public override double GetCircumference()
        {
            return 0;
        }
    }
}
