using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    struct Complex
    {
        private double a, b;

        //public void SetA(double value) { a = value; }
        //public void SetB(double value) { b = value; }

        //public double GetA() { return a; }
        //public double GetB() { return b; }

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
        public Complex(double ReIn, double ImIn)
        {
            a = ReIn;
            b = ImIn;
        }

        static public Complex operator + (Complex x, Complex y)
        {
            return new Complex(
                ReIn: x.a + y.a,
                ImIn: x.b + y.b);
        }

        static public Complex operator - (Complex x, Complex y)
        {
            return new Complex(
                ReIn: x.a - y.a,
                ImIn: x.b - y.b);
        }
        static public Complex operator * (Complex x, Complex y)
        {
            return new Complex(
                ReIn: x.a * y.a - x.b * y.b,
                ImIn: x.b * y.a + x.a * y.b);
        }

        public override string ToString()
        {
            if (b < 0 && a!=0) return $"{a} - {-b}i";
            else if (b == 0) return $"{a}";
            else if (a == 0) return $"{b}i";
            else return ($"{a} + {b}i");

         
        }
       

    }
}
