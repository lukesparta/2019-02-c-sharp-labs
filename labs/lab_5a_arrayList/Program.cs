using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5a_arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------    
             * Array List   
             * 
             * ArrayList is a non-generic type of collection in C#. It can contain elements of any data types. It is similar to an array, except that it grows automatically as you add items in it. Unlike an array, you don't need to specify the size of ArrayList.
             * 
             * ----------*/

            ArrayList al = new ArrayList(){
                100,
                "Two Hundred"
            };

            //OR

            ArrayList al2 = new ArrayList();
            //Add - adds single elements at the end of ArrayList. 
            al2.Add(100);
            al2.Add("Two Hundred");

            //Insert - insert a single elements at the specified index in ArrayList. 
            al2.Insert(1, "Second Item");

            //Remove - removes the specified element from the ArrayList.
            al2.Remove(100);

            //Sort - sorts entire elements of the ArrayList.
            al2.Sort();

            //Reverse - Reverses the order of the elements in the entire ArrayList.
            al2.Reverse();

            //Contains - Checks whether specified element exists in the ArrayList or not. Returns true if exists otherwise false.
            al2.Contains(100); //returns false
        }
    }
}
