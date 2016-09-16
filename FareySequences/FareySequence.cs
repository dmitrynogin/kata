using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareySequences
{
    public class FareySequence : IEnumerable<RationalNumber>
    {
        public FareySequence(int order)
        {
            Members = new SortedSet<RationalNumber>();
            for (int d = 1; d <= order; d++)
                for (int n = 0; n <= d; n++)
                    Members.Add(new RationalNumber(n, d));
        }

        public override string ToString() =>
            "{" + string.Join(", ", this) +"}";

        public IEnumerator<RationalNumber> GetEnumerator() => Members.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Members.GetEnumerator();
        SortedSet<RationalNumber> Members { get; }
    }
}
