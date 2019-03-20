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
           // Assert.True(24);
        }
        [Test]
        public void Test2()
        {
            Assert.True(true);
            Assert.False(false);
        }


        void nested()
        {
           Assert.Fail2();
        }
        [Test]
        public void Test3()
        {
            this.nested();
        }

    }
}