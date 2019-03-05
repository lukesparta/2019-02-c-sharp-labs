
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_121_hash_set_to_excel
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class HashSetToExcel
    {
        public Custom HashSetToExcelTest(int a, int b, int c)
        {

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

            Stopwatch stopwatch = new Stopwatch();
            LinkedList<int> linkedList = new LinkedList<int>();
            HashSet<int> hashSet = new HashSet<int>();
            Dictionary<int, double> dict = new Dictionary<int, double>();
            int count = 0;

            stopwatch.Start();

            int[] nums = new int[] { a, b, c };

            foreach(int number in nums)
            {
                linkedList.AddLast(number*2);
            }

            foreach(int number in linkedList)
            {
                hashSet.Add(number * 2);
            }

            foreach(int number in hashSet)
            {
                double newNum = 15 + number;
                dict.Add(count, Math.Pow(newNum, 3));
                count++;
            }

            stopwatch.Stop();

            Custom cust = new Custom((int)stopwatch.ElapsedMilliseconds, dict[1], dict[2], dict[3]);

            return cust;
        }

        public class Custom
        {
            public int ElapsedT { get; set; }
            public double firstNum { get; set; }
            public double secondNum { get; set; }
            public double thirdNum { get; set; }

            public Custom(int eT, double firstN, double secondN, double thirdN)
            {
                ElapsedT = eT;
                firstNum = firstN;
                secondNum = secondN;
                thirdNum = thirdN;
            }
        }

    }
}
