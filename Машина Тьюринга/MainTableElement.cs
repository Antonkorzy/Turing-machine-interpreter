using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Машина_тьюринга
{
    class Code
    {
            public string alph;
            public char direction;
            public int q;
            public Code()
            {
                alph = "";
                direction = ' ';
                q = 0;
            }
            public Code(string Alph, char Direction, int Q)
            {
                alph = Alph;
                direction = Direction;
                q = Q;
            }
            public override string ToString()
            {
                return alph + direction + q;
            }
    }
}
