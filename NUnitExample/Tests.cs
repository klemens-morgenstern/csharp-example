using System;
using NUnit.Framework;

namespace NUnitExample
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        [Test]
        public void Test2()
        {
            Assert.True(true);
            Assert.False(false);
        }


        void nested()
        {
           // Assert.Fail();
        }
        [Test]
        public void Test3()
        {
            this.nested();
        }

    }
}