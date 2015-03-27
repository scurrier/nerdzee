using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdzee
{
    public class StraightRule : Rule
    {
        private int length;

        public int Length
        {
            get { return length; }
        }

        private int score;

        public int ScoreValue
        {
            get { return score; }
        }

        public StraightRule(int length, int score)
        {
            this.length = length;
            this.score = score;
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
                if (countStraight >= length)
                    return score;
            }
            return 0;
        }
    }
}
