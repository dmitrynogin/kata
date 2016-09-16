using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public RomanNumeral(string value)
        {
            Value = value;
        }

        // http://www.rapidtables.com/convert/number/how-roman-numerals-to-number.htm
        public int ToInt32()
        {
            var table = new[]
            {
                new { Numeral="I", Value=1 },
                new { Numeral="IV", Value=4 },
                new { Numeral="V", Value=5 },
                new { Numeral="IX", Value=9 },
                new { Numeral="X", Value=10 },
                new { Numeral="XL", Value=40 },
                new { Numeral="L", Value=50 },
                new { Numeral="XC", Value=90 },
                new { Numeral="C", Value=100 },
                new { Numeral="CD", Value=400 },
                new { Numeral="D", Value=500 },
                new { Numeral="CM", Value=900 },
                new { Numeral="M", Value=1000 }
            };

            var x = 0;
            var r = Value;
            while(r != string.Empty)
                foreach (var n in table.Reverse())
                    if(r.StartsWith(n.Numeral))
                    {
                        x += n.Value;
                        r = r.Substring(n.Numeral.Length);
                        break;
                    }

            return x;
        }

        string Value { get; }
    }
}
