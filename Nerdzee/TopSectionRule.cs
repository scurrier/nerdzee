using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class TopSectionRule : Nerdzee.IRule
    {
        public int Pips {get; private set;}

        public TopSectionRule(int value)
        {
            Pips = value;
        }

        public override int Score(int[] rolls)
        {
            return rolls.Count(a => a == Pips) * Pips;
        }
    }
}
