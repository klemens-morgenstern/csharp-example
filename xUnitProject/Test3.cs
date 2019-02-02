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

        [Fact]
        public void Test1()
        {
            output.WriteLine("Some out line");
            Assert.True(true);
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Null(null);
            Assert.True(true);
            throw new Exception("Dummy exception");
        }
        
    }

}