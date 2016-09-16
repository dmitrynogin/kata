using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareySequences
{
    public class RationalNumber 
    {
        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denomerator = denominator;
        }

        public override string ToString() => $"{Numerator}/{Denomerator}";
        int Numerator { get; }
        int Denomerator { get; }
    }
}
