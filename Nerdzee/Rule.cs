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
        public static Rule Threes = new Rule(3);
        public int Pips {get; private set;}

        public Rule(int value)
        {
            Pips = value;
        }

        public int Score(int[] rolls)
        {
            return rolls.Count(a => a == Pips) * Pips;
        }

        public static Rule Create(string name)
        {
            switch (name)
            {
                case "Ones":
                    return Ones;
                case "Twos":
                    return Twos;
                case "Threes":
                    return Threes;
                default:
                    throw new ArgumentException("ArgueMints: " + name);
            }
        }
    }
}
