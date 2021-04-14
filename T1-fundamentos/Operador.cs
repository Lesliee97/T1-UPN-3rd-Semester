using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace T1_fundamentos
{
    class Operador
    {
        public struct Sum
        {
            public double real;
            public double imag;

            public static Sum operator +(Sum s1, Sum s2)
            {
                Sum nc = new Sum();

                nc.real = s1.real + s2.real;

                nc.imag = s1.imag + s2.imag;

                return nc;
            }

        }
        public struct Resta
        {
            public double real;
            public double imag;

            public static Resta operator +(Resta r1, Resta r2)
            {
                Resta nc = new Resta();

                nc.real = r1.real - r2.real;

                nc.imag = r1.imag - r2.imag;

                return nc;
            }

        }
        public struct Multiply
        {

            public double real;
            public double imag;

            // Operador sobrecargado
            public static Multiply operator *(Multiply m1, Multiply m2)
            {
                Multiply nc = new Multiply();
                
                nc.real = ((m1.real * m2.real) + (-1 * (m1.imag * m2.imag)));
              
                nc.imag = ((m1.real * m2.imag) + (m1.imag * m2.real));

                return nc;
            }

            public struct Div
            {
                public double real;
                public double imag;

                public static Div operator /(Div d1, Div d2)
                {

                    Div nc = new Div();

                    nc.real = ((d1.real * d2.real) + (d1.imag * d2.imag)) / ((d2.real * d2.real) + (d2.imag * d2.imag));
                    nc.imag = ((d1.imag * d2.real) - (d1.real * d2.imag)) / ((d2.real * d2.real) + (d2.imag * d2.imag));

                    return nc;
                }
            }
        }
    }
}
