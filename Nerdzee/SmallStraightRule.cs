using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class SmallStraightRule : Rule
    {
        public SmallStraightRule()
        {
        }

        public override int Score(int[] rolls)
        {
            Array.Sort(rolls);
            int countStraight = 1;
            int maxStraight = countStraight;
            for (int index = 0; index < rolls.Length - 1; index++ )
            {
                if (rolls[index] + 1 != rolls[index + 1])
                    countStraight = 0;
                countStraight++;
                if (countStraight > maxStraight)
                    maxStraight = countStraight;
            }
            if(maxStraight >= 4)
                return 30;
            return 0;
        }
    }
}
