using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();     //syntatic sugar - when you complie and make the code its exactly the same
            Parent p02 = new Parent();  //regular code

            p01.Age = 10;

            dynamic x = 10;     //dynamic has no type until run time
            /*
             Console.WriteLine("x+1") will print out 11
             if x was a string of 10 it would print out 101
             */

        }
    }

    class Parent {
        //field
        private int x;

        //property
        private string y { get; set; } //short hand
        private string ReadMeOnly { get; } //read only
        private int age;
        public int Age { //long hand
            get
            {
                return this.age;
            }

            set
            {
                if (value > 0)
                {
                    this.age = value;   //Keyword value -
                }
                 
            }
        }

        //method


    }

    class Child : Parent {
    }
}
