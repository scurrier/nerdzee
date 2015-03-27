using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nerdzee;

namespace NunitTests
{
    [TestFixture]
    public class LargeStraightRuleTest
    {
        [Test]
        public void ScoreLargeStraight()
        {
            var testObj = new LargeStraightRule();
            Assert.AreEqual(40, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreUnsortedLargeStraight()
        {
            var testObj = new LargeStraightRule();
            Assert.AreEqual(40, testObj.Score(new[] { 2, 4, 3, 5, 6 }));
        }

        [Test]
        public void ScoreInvalidLargeStraight()
        {
            var testObj = new LargeStraightRule();
            Assert.AreEqual(0, testObj.Score(new[] { 1, 2, 4, 5, 6 }));
        }

        [Test]
        public void Create()
        {
        }
    }
}
