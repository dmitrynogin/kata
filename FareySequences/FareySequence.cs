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

        }

        public IEnumerator<RationalNumber> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
