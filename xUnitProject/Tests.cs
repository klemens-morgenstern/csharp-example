﻿using Xunit;

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
        
        [Fact]
        public void Test2()
        {
            Assert.Null(null);
            Assert.False(true);
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
            Assert.True(true);
        }
        
    }

}