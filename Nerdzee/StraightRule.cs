using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class StraightRule : Rule
    {
        public int Length { get; private set; }
        public int ScoreValue { get; private set; }

        public StraightRule(int length, int score)
        {
            Length = length;
            ScoreValue = score;
        }

        public override int Score(int[] rolls)
        {
            Array.Sort(rolls);
            rolls = rolls.Distinct().ToArray();
            int countStraight = 1;
            for (int index = 0; index < rolls.Length - 1; index++ )
            {
                if (rolls[index] + 1 != rolls[index + 1])
                    countStraight = 1;
                else
                    countStraight++;
                if (countStraight >= Length)
                    return ScoreValue;
            }
            return 0;
        }
    }
}
