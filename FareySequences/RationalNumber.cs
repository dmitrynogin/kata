using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareySequences
{
    public class RationalNumber : IComparable<RationalNumber>, IEquatable<RationalNumber>
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

        public override int GetHashCode() =>
            (Numerator / Denomerator).GetHashCode();

        public override bool Equals(object obj) =>
            Equals(obj as RationalNumber);

        public bool Equals(RationalNumber other) =>
            other != null &&
            Numerator * other.Denomerator - other.Numerator * Denomerator == 0;

        int Numerator { get; }
        int Denomerator { get; }
    }
}
