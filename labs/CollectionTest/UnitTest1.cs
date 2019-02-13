using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using collections;

namespace CollectionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CollectionTest01()
        {
            // Arrange - Set the expected
            var expected = 100;
            //create instance of class
            var instance01 = new Collection01();

            // Act 
            var actual = instance01.Collection_Test_01();


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
