using System;
using NUnit.Framework;

namespace fbxdiff.Tests
{
    [TestFixture]
    public class NullTest
    {
        [Test]
        public void JustDoSomething()
        {
            Assert.IsTrue(true);
            FbxDiff.MainClass.DoSomething();
        }
    }
}

