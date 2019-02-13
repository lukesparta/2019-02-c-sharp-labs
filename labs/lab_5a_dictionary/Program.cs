using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5a_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               The Dictionary collection in C# is same as English dictionary. English dictionary is a collection of words and their definitions, often listed alphabetically in one or more specific languages. In the same way, the Dictionary in C# is a collection of Keys and Values, where key is like word and value is like definition.
               
                The Dictionary class is a generic collection class in the System.Collection.Generics namespace. TKey denotes the type of key and TValue is the type of TValue.
             */

            IDictionary<int, string> dict = new Dictionary<int, string>(); //Create a new dictionary
            /*It is recommended to program to the interface rather than to the class. So, use IDictionary<TKey, TValue> type variable to initialize a dictionary object.*/


            //Add(key, value) - Adds an item to the Dictionary collection.
            dict.Add(1, "Item-One");
            dict.Add(2, "Item-Two");
            dict.Add(3, "Item-Three");
            dict.Add(4, "Item-Four");

            //Loops through the dictionary and prints out the keys and values
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
