using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nerdzee;

namespace NunitTests
{
    [TestFixture]
    public class StraightRuleTest
    {
        private StraightRule testObj;
        [SetUp]
        public void SetUp()
        {
            testObj = new StraightRule(4, 30);
        }

        [Test]
        public void ScoreSmallStraight()
        {
            Assert.AreEqual(30, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreUnsortedSmallStraight()
        {
            Assert.AreEqual(30, testObj.Score(new[] { 2, 4, 3, 5, 6 }));
        }

        [Test]
        public void ScoreInvalidSmallStraight()
        {
            Assert.AreEqual(0, testObj.Score(new[] { 1, 2, 4, 5, 6 }));
        }

        [Test]
        public void ScoreActuallySmallStraight()
        {
            Assert.AreEqual(30, testObj.Score(new[] { 1, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreSmallStraightAtBeginning()
        {
            Assert.AreEqual(30, testObj.Score(new[] { 1, 3, 4, 2, 7 }));
        }

        [Test]
        public void ScoreStraightOfLengthThree()
        {
            Assert.AreEqual(0, testObj.Score(new[] { 1, 3, 5, 2, 7 }));
        }

        [Test]
        public void ScoreSmallStraightWithDuplicates()
        {
            Assert.AreEqual(30, testObj.Score(new[] { 1, 3, 3, 2, 4 }));
        }

        //Large Straights
        [Test]
        public void ScoreLargeStraight()
        {
            var testObj = new StraightRule(5, 40);
            Assert.AreEqual(40, testObj.Score(new[] { 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void ScoreUnsortedLargeStraight()
        {
            var testObj = new StraightRule(5, 40);
            Assert.AreEqual(40, testObj.Score(new[] { 2, 4, 3, 5, 6 }));
        }

        [Test]
        public void ScoreInvalidLargeStraight()
        {
            var testObj = new StraightRule(5, 40);
            Assert.AreEqual(0, testObj.Score(new[] { 1, 2, 4, 5, 6 }));
        }
    }
}
