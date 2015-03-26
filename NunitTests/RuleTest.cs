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
            var testObj = new Rule(1);
            Assert.AreEqual(0, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
            Assert.AreEqual(1, testObj.Score(new[] { 2, 3, 4, 1, 6 }));
            Assert.AreEqual(5, testObj.Score(new[] { 1, 1, 1, 1, 1 }));
        }

        [Test]
        public void ScoreTwos()
        {
            var testObj = new Rule(2);
            Assert.AreEqual(2, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }
    }
}
