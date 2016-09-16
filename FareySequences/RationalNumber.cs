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
            if (denominator == 0)
                throw new ArgumentException("Denominator can not be 0.", "denominator");

            Numerator = numerator;
            Denomerator = denominator;
        }

        public override string ToString() => $"{Numerator}/{Denomerator}";

        public int CompareTo(RationalNumber other) =>
            Math.Sign(Numerator*other.Denomerator - other.Numerator*Denomerator) * 
            Math.Sign(Denomerator*other.Denomerator);

        int Numerator { get; }
        int Denomerator { get; }
    }
}
