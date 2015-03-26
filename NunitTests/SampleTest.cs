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

        [Test]
        public void Ones()
        {
            var testObj = new Nerdzee.Game();
            Assert.AreEqual(0, testObj.Score(Rule.Ones, new []{2,3,4,5,6}));
        }
    }
}
