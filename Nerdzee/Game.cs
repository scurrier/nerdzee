using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class Game
    {
        public int Score(Rule rule, int[] p)
        {
            return p.Count(a => a == 1);
        }
    }
}
