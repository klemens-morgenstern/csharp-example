using Xunit;

namespace xUnitProject
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
            Assert.True(false);
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Null(null);
            Assert.True(false);
        }
        
    }
    
    public class Tests2
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
            Assert.True(false);
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Null(null);
            Assert.True(false);
        }
        
    }

}