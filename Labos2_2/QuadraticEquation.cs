using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2_2
{
    public class QuadraticEquation
    {

        public QuadraticEquation()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double Y(double x)
        {
            return a * x * x + b * x + c;
        }

        public double Discriminant
        {
            get { return b * b - 4 * a * c; }
        }

        public double[] Roots
        {
            get
            {
                if (a == 0)
                {
                    return new double[] { -c / b, -c / b };
                }
                double sqrtDisc = Math.Sqrt(Discriminant);
                return new double[] { ((-b - sqrtDisc) / (2 * a)), ((-b + sqrtDisc) / (2 * a)) };
            }
        }

        private double a;
        private double b;
        private double c;
    }
}
