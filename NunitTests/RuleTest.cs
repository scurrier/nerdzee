using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nerdzee;

namespace NunitTests
{
    [TestFixture]
    public class RuleTest
    {
        [Test]
        public void Create()
        {
            Assert.Throws<ArgumentException>(() => TopSectionRule.Create("NegativeTwenties"));
            Assert.That(((TopSectionRule)Rule.Create("Ones")).Pips, Is.EqualTo(1));
            Assert.That(((TopSectionRule)Rule.Create("Twos")).Pips, Is.EqualTo(2));
            Assert.That(((TopSectionRule)Rule.Create("Threes")).Pips, Is.EqualTo(3));
            Assert.That(Rule.Create("LargeStraight"), Is.TypeOf<LargeStraightRule>());
        }
    }
}
