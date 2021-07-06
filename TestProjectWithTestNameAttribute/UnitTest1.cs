using System;
using NUnit.Framework;

namespace TestProjectWithTestNameAttribute
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [TestCase(1, TestName = "Hallo")]
        [TestCase(2)]
        [TestCase(3)]
        public void Test(int i)
        {
            
        }
    }
}