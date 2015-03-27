﻿using System;
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
        public void ScoreOnes()
        {
            var testObj = new TopSectionRule(1);
            Assert.AreEqual(0, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
            Assert.AreEqual(1, testObj.Score(new[] { 2, 3, 4, 1, 6 }));
            Assert.AreEqual(5, testObj.Score(new[] { 1, 1, 1, 1, 1 }));
        }

        [Test]
        public void ScoreTwos()
        {
            var testObj = new TopSectionRule(2);
            Assert.AreEqual(2, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreThrees()
        {
            var testObj = new TopSectionRule(3);
            Assert.AreEqual(3, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void Create()
        {
            Assert.Throws<ArgumentException>(() => TopSectionRule.Create("NegativeTwenties"));
            Assert.That(((TopSectionRule)IRule.Create("Ones")).Pips, Is.EqualTo(1));
            Assert.That(((TopSectionRule)IRule.Create("Twos")).Pips, Is.EqualTo(2));
            Assert.That(((TopSectionRule)IRule.Create("Threes")).Pips, Is.EqualTo(3));
        }
    }
}
