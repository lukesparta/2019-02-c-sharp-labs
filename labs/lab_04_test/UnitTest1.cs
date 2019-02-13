using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_04_array;

namespace lab_04_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange (set up)
            Program arrayInstance = new lab_04_array.Program();
            var expectedOutput = 22;

            //Act (run code)
            var actualOutput = arrayInstance.CreateArray(10);

            //Assert (see if the test passed/failed)
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
