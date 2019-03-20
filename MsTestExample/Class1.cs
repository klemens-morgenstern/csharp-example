using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExample
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void func1()
        {
//            Assert.Fail();
        }

        void nested(int i)
        {
            Assert.AreEqual(i,2);

        }
        
        [TestMethod]
        public void func2()
        {
            nested();
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(0)]
        [DataRow(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            Assert.IsFalse(value < 0, $"{value} should not be prime");
        }
        
    }
}