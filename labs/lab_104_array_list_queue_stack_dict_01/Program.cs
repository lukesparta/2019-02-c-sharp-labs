using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[10];
            List<int> intList = new List<int>();
            Stack<int> intStack = new Stack<int>();
            Queue<int> intQueue = new Queue<int>();
            IDictionary< int, int> intDict = new Dictionary<int, int>();

            //Put 10 numbers in an array
            for (var i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i;
            }
            
            for(var i = 0; i < intArr.Length; i++)
            {
                //Move the items to a list and add 1 to the int
                intList.Add(intArr[i] + 1);
                //Move to a stack and add 1 to the int
                intStack.Push(intList[i]+1);
                //Move to queue and add 1 to the int
                intQueue.Enqueue(intStack.Peek()+1);
                //Move to dictionary and add 1 to the int
                intDict.Add(i, intQueue.Dequeue() + 1);

            }
            //Return total
            var total = 0;
            for (var i = 0; i < intDict.Count; i++)
            {
                total += intDict[intDict.Keys.ElementAt(i)];
            }
            Console.WriteLine(total);
        }
    }
}
