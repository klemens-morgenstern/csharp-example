using System;
using Xunit;
using Xunit.Abstractions;

namespace xUnitProject
{
    
    public class Tests3
    {
        private readonly ITestOutputHelper output;

        public Tests3(ITestOutputHelper output)
        {
            this.output = output;
        }

        void Impl(int x)
        {
            Assert.True(x < 42);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(42)]

        [InlineData(32)]
        public void Test1( int x )
        {
            output.WriteLine("Some out line");
            Impl(x);
            
       }
        
        [Fact]
        public void Test2()
        {
            Assert.Null(null);
            Assert.True(true);
            //throw new Exception("Dummy exception");
        }
        
    }

}