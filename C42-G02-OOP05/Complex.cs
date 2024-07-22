﻿using System;
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

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left.Real + Right.Real,
                Imag = Left.Imag + Right.Imag
            };
        }
        public static Complex operator -(Complex Left, Complex Right) {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };
        }
        public static Complex operator ++(Complex C) {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0) + 1
            };
        }
        public static /*int*/ explicit operator int (Complex C){
            return C?.Real??0;
        }
        public static /*String*/ explicit operator String(Complex C)
        {
            return C?.ToString()  ?? String.Empty;
        }
    }
}
