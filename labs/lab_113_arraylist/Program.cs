using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_113_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class arrayList
    {
        public int arrayListMethod(int a, int b, int c, int d)
        {
            /*Accept four integers
             * 
             * put to array
             * extract ==> double ==> put to queue
             * extract ==> double ==> put to stack
             * extract ==> square ==> put to dictionary
             * put to arrayList
             * extract and get the sum of the items and return this sum
             */

            int[] array = new int[] { a, b, c, d };
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            IDictionary<int, int> dict = new Dictionary<int, int>();
            ArrayList aList = new ArrayList();
            int total = 0;

            foreach(int num in array)
            {
                queue.Enqueue(num * 2);
            }

            foreach (int num in queue)
            {
                stack.Push(num * 2);
            }

            int sc = stack.Count();
            for(int i = 0; i < sc; i++)
            {
                int num = stack.Pop();
                dict.Add(i, num*num);

            }

            foreach (KeyValuePair<int, int> item in dict)
            {
                aList.Add(item.Value);
            }

            foreach (var val in aList)
            {
                total += Convert.ToInt32(val);
            }

            return total;
        }
    }
}
