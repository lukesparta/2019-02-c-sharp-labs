using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent("Bob");
            var p02 = new Parent("June", 39);
            var p03 = new Parent(age: 33, name: "Jack"); //named parameters
            p01.Name = "Bob";
        }
    }

    class Parent
    {
        public string Name { get; set; } //get set is used for any field that is public
        public int Age { get; set; }

        //Contructor method
        public Parent() { } // defult contructor - if you dont code one, this will automatically be added. If you create a new one, itll be removed
        public Parent(string name)  //constructor to define name
        {
            this.Name = name;
        }
        public Parent(string name, int age) //contructor to define name and age
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
