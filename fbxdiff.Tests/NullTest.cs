using System;
using NUnit.Framework;

namespace FbxDiff.Tests
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

