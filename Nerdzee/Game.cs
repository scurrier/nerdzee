using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class Game
    {
        public int Score(IRule rule, int[] p)
        {
            return rule.Score(p);
        }
    }
}
