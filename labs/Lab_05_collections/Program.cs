using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----------   List  -------------*/
            List<int> myList = new List<int>();
            // Add
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }

            //Remove
            myList.Remove(10);

            //AddAt
            

            //RemoveAt
            myList.RemoveAt(2);



            /*-----------   Queue  (FIFO - First In First Out)  -------------*/

            Queue<int> queue = new Queue<int>();

            // Enqueue - Adds an item into the queue.
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            // Dequeue - Removes and returns an item from the beginning of the queue.
            queue.Dequeue();

            //Peek - Returns an first item from the queue
            queue.Peek();

            //Contains - Checks whether an item is in the queue or not
            if (queue.Contains(1))
            {
                Console.WriteLine("Queue contains 1");
            }

            //Clear - Removes all the items from the queue.
            queue.Clear();



            /*-----------   Stack  (Last In First Out)  -------------*/
            Stack<int> myStack = new Stack<int>();

            //Push - Inserts an item at the top of the stack.
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            //Pop - Returns the top item from the stack.
            myStack.Pop();

            //Peek - Removes and returns items from the top of the stack.
            myStack.Peek();


            //Contains - Checks whether an item exists in the stack or not.
            myStack.Contains(10); //returns false

            //Clear - Removes all items from the stack.
            myStack.Clear();
        }
    }
}
