using NUnit.Framework;
using lab_121_hash_set_to_excel;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        /*
        
        1. Start stopwatch.
        2. Pass 3 number to an arrray.
        3. Double numbers and pass to linked list.
        4. Double numbers and pass to a hash set.
        5. Add 15 to all numbers, then treble numbers and pass to a Dictionary.
        6. Stop the stopwatch.
        7. Return the test as a custom object containing
            - ElapsedTime (integer, will be in milliseconds)
            - First number.
            - Second number.
            - Third number.
        8. Test passes if stopwatch time is less than the time passed in (4th variable, set to 10 seconds).
        
        NOT PART OF THE TEST
        9. Output all values to .csv text file and append to existing file.
            - Input 4 PARAMS
            - Output 4 PARAMS
        10. Finally launch excel to read this file using Process.Start.
             
        */

        [TestCase(10, 20, 30, 10)]
        public void HashSetExcelTest1(int a, int b, int c, int d)
        {
            //arrange
            var instance = new HashSetToExcel();
            //act
            var actual = instance.HashSetToExcelTest(a, b, c);

            //assert
            Assert.IsTrue(4 < d);
        }
    }
}