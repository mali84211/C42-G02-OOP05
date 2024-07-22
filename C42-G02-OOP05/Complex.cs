using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static Complex operator +(Complex Left,Complex Right) 
        {
            return new Complex()
            {
            Real = Left.Real+Right.Real,
            Imag = Left.Imag+Right.Imag
            };
        }
        public static Complex operator -(Complex Left, Complex Right) {
            return new Complex()
            {
                Real = (Left?.Real??0) - (Right?.Real??0),
                Imag = (Left?.Imag??0) + (Right?.Imag??0)
            };
        }
    }
}
