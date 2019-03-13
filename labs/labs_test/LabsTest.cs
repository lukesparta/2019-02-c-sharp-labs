using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;
using lab_113_arraylist;


namespace labs_test
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void Lab112CollectionTest()
        {
            // arrange
            var expected01 = -10;
            var expected02 = -10;
            var instanceLab112Collection = new Collections();

            // act
            var actual01 = instanceLab112Collection.Collections20MinuteLab(10, 20, 30);
            var actual02 = instanceLab112Collection.Collections20MinuteLab(1, 2, 3);

            // assert
            Assert.AreEqual(expected01, actual01);
            Assert.AreEqual(expected02, actual02);
        }



        //TEST FOR LAB 113
        [TestMethod]
        public void Lab113CollectiArrayListTest()
        {
            // arrange
            var expected = 480;
            var instanceLab113 = new arrayList();

            // act
            var actual = instanceLab113.arrayListMethod(1,2,3,4);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
