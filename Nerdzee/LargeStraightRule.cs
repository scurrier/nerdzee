using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class LargeStraightRule : Rule
    {
        public LargeStraightRule()
        {
        }

        public override int Score(int[] rolls)
        {
            Array.Sort(rolls);
            for (int index = 0; index < rolls.Length - 1; index++ )
            {
                if (rolls[index] + 1 != rolls[index + 1])
                    return 0;
            }
            return 40;
        }
    }
}
