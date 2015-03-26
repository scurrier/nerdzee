using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nerdzee;

namespace NunitTests
{
    /// <summary>
    /// A test class for ...
    /// </summary>
    [TestFixture]
    public class NerdzeeTest
    {
        private Game testObj;

        [SetUp]
        public void SetUp() {
            testObj = new Game();
        }

        [Test]
        public void Ones()
        {
            Assert.AreEqual(0, testObj.Score(Rule.Ones, new[] { 2, 3, 4, 5, 6 }));
            Assert.AreEqual(1, testObj.Score(Rule.Ones, new[] { 2, 3, 4, 1, 6 }));
            Assert.AreEqual(5, testObj.Score(Rule.Ones, new[] { 1, 1, 1, 1, 1 }));
        }

        [Test]
        public void Twos()
        {
            Assert.AreEqual(2, testObj.Score(Rule.Twos, new[] { 2, 3, 4, 5, 6 }));
        }
    }
}
