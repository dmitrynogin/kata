using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareySequences
{
    public class RationalNumber : IComparable<RationalNumber>
    { 
        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denomerator = denominator;
        }

        public override string ToString() => $"{Numerator}/{Denomerator}";

        public int CompareTo(RationalNumber other)
        {
            throw new NotImplementedException();
        }

        int Numerator { get; }
        int Denomerator { get; }
    }
}
