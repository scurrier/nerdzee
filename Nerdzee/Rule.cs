using System;
namespace Nerdzee
{
    public abstract class Rule
    {
        public static TopSectionRule Ones = new TopSectionRule(1);
        public static TopSectionRule Twos = new TopSectionRule(2);
        public static TopSectionRule Threes = new TopSectionRule(3);
        public static StraightRule LargeStraight = new StraightRule(5, 40);
        public static StraightRule SmallStraight = new StraightRule(4, 30);

        public abstract int Score(int[] rolls);

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
                case "LargeStraight":
                    return LargeStraight;
                case "SmallStraight":
                    return SmallStraight;
                default:
                    throw new ArgumentException("ArgueMints: " + name);
            }
        }
    }
}
