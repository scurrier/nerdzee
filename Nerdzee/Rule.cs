using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class Rule
    {
        public static Rule Ones = new Rule(1);
        public static Rule Twos = new Rule(2);
        private int pips;

        public Rule(int value)
        {
            pips = value;
        }

        public int Score(int[] rolls)
        {
            return rolls.Count(a => a == pips) * pips;
        }

        public static Rule Create(string name)
        {
            return Ones;
        }

    }


}
