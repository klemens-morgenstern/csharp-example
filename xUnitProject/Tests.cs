using Xunit;

namespace xUnitProject
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
            Assert.False(false);
        }

        void nested()
        {
            Assert.True(42);
        }
        [Fact]
        public void Test2()
        {
            nested();
            Assert.Null(null);
            Assert.False(0);
        }
        
    }
    
    public class Tests2
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
            Assert.False(0);
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Null(null);
            Assert.True(true);
        }
        
    }

}