using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Collections();

            c.Collections20MinuteLab(10, 20, 30);
        }
    }

    public class Collections
    {
        /*
         * Receive 3 numbers
         * 
         * Put these 3 numbers into an array
         * 
         * Output numbers, double each one and store in a stack
         * 
         * Repeat i.e. Output numbers, double and store in queue
         * 
         * Output numbers, square them and store in List<int>
         * 
         * Add up numbers in the List<int> and return total
         */
        public int Collections20MinuteLab(int num1, int num2, int num3)
        {
            int[] intArray = new int[] { num1, num2, num3 };
            Stack<int> intStack = new Stack<int>();
            Queue<int> intQueue = new Queue<int>();
            List<int> intList = new List<int>();
            int returnVal = 0;


            //Output numbers in array
            foreach (int item in intArray)
            {
                Console.WriteLine($"\nNumbers in Array...\n{item}\n");
            }
           
            //Double numbers in array, put them in a stack and output numbers in stack
            foreach (int item in intArray)
            {
                //Output numbers, double each one and store in a stack
                Console.WriteLine($"\nNumbers in Stack...\n{item*2}\n");

                //and store in a stack
                intStack.Push(item*2);
            }

            //Double numbers in stack, put them in queue and output numbers
            foreach(int item in intStack)
            {
                //Output numbers, double each one and store in a stack
                Console.WriteLine($"\nNumbers in Queue...\n{item*2}\n");

                //and store in a stack
                intQueue.Enqueue(item*2);
            }

            //Square numbers in queue, put them in a List and output numbers
            foreach (var item in intQueue)
            {
                intList.Add(item*item);
                returnVal += item * item;
            }

            Console.WriteLine(returnVal);
            return returnVal;
        }
    }
}
