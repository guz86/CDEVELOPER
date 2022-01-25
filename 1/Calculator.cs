using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Calculator
    {

        // S= p⋅(p−a)⋅(p−b)⋅(p−c)
        // где aa, bb, cc — стороны, pp — полупериметр,
        // который можно найти по формуле: p = (a + b + c) \div 2p=(a+b+c)÷2

        public double CalcTriangeSquare(double ab, double bc, double ca)
        {
            double p = (ab + bc + ca) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
            //double square = Math.Sqrt(p*(p - ab) * (p - bc) * (p - ca));
            //return square;
        }

        // половины основания треугольника (a) на его высоту (h)
        public double CalcTriangeSquare(double a, double h)
        {
            return 0.5 * a * h;
        }

        // среднее
        public double Avarage(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum+=array[i];
            }
            return sum / array.Length;
        }

        public double AvarageParams(params int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}
