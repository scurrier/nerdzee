using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nerdzee;

namespace NunitTests
{
    [TestFixture]
    public class SmalltraightRuleTest
    {
        [Test]
        public void ScoreSmallStraight()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(30, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreUnsortedSmallStraight()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(30, testObj.Score(new[] { 2, 4, 3, 5, 6 }));
        }

        [Test]
        public void ScoreInvalidSmallStraight()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(0, testObj.Score(new[] { 1, 2, 4, 5, 6 }));
        }

        [Test]
        public void ScoreActuallySmallStraight()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(30, testObj.Score(new[] { 1, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreSmallStraightAtBeginning()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(30, testObj.Score(new[] { 1, 3, 4, 2, 7 }));
        }

        [Test]
        public void ScoreStraightOfLengthThree()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(0, testObj.Score(new[] { 1, 3, 5, 2, 7 }));
        }

        [Test]
        public void ScoreSmallStraightWithDuplicates()
        {
            var testObj = new SmallStraightRule();
            Assert.AreEqual(30, testObj.Score(new[] { 1, 3, 3, 2, 4 }));
        }
    }
}
