using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        static IEnumerable<Tuple<string, int>> Table { get; } =
            new []
            {
                Tuple.Create("I", 1),
                Tuple.Create("IV", 4),
                Tuple.Create("V", 5),
                Tuple.Create("IX", 9),
                Tuple.Create("X", 10),
                Tuple.Create("XL", 40),
                Tuple.Create("L", 50),
                Tuple.Create("XC", 90),
                Tuple.Create("C", 100),
                Tuple.Create("CD", 400),
                Tuple.Create("D", 500),
                Tuple.Create("CM", 900),
                Tuple.Create("M", 1000)
            }
            .Reverse();

        public RomanNumeral(string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            if (value.Trim('I', 'V', 'X', 'L', 'C', 'D', 'M') != string.Empty)
                throw new ArgumentException("Malformed value.", "value");

            Value = value;
        }

        // http://www.rapidtables.com/convert/number/how-number-to-roman-numerals.htm
        public RomanNumeral(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("value");

            while (value > 0)
                foreach (var n in Table)
                    if (value >= n.Item2)
                    {
                        Value += n.Item1;
                        value -= n.Item2;
                        break;       
                    }
        }

        // http://www.rapidtables.com/convert/number/how-roman-numerals-to-number.htm
        public int ToInt32()
        {
            var x = 0;
            var r = Value;
            while(r != string.Empty)
                foreach (var n in Table)
                    if (r.StartsWith(n.Item1))
                    {
                        x += n.Item2;
                        r = r.Substring(n.Item1.Length);
                        break;
                    }

            return x;
        }

        public override string ToString() => Value;
        string Value { get; }        
    }
}
