using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Calculator
    {
        public double CalcTriangeSquare(double ab, double bc, double ca)
        {
            double p = (ab + bc + ca) / 2;

            double square = Math.Sqrt(p*(p - ab) * (p - bc) * (p - ca));
            return square;
        }
    }
}
