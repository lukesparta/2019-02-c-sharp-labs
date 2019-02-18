using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace random_person
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = new string[] { "Luke Dawes", "John Doe",
                                        "James Carter", "Travis Scott",
                                        "Donald Trump", "Burno Mars",
                                        "Justin Beiber", "Frank Ocean",
                                        "Beyonce Knowles", "Lauyrn Hill"};


            string year = randomNumberGen(1919, 2019).ToString();
            string month = randomNumberGen(1, 12).ToString();
            string day = randomNumberGen(1, 31).ToString();
            DateTime dob = Convert.ToDateTime($"{year}/{month}/{day}");
            DateTime Today = DateTime.Now;
            TimeSpan ts = Today - dob;
            DateTime Age = DateTime.MinValue + ts;


            // note: MinValue is 1/1/1 so we have to subtract...
            int Years = Age.Year - 1;
            int Months = Age.Month - 1;
            int Days = Age.Day - 1;

            

            for (var i = 0; i < 100; i++)
            {
                Parent p01 = new Parent();
                p01.name = people[randomNumberGen(0, 10)];
                p01.age = randomNumberGen(1, 100);
                p01.dob = dob;

                Console.WriteLine($"{p01.name} {p01.age} {p01.dob}");
                Thread.Sleep(1000);
            }
        }

        //randomly select person from array
        static public int randomNumberGen(int b1, int b2)
        {
            Random randomNum = new Random();
            return randomNum.Next(b1, b2);
        }
    }

    

    class Parent
    {
        //properties
        public string name;
        public int age;
        public DateTime dob;
        /*
         Use a randomise function to pick a random name from the array, also an age 1 to 100, 
       also a date constructed from dd/mm/yyyy where dd,mm and yyyy are randomly generated
     Using our random data instantiate a new instance of our parent class to create a new object
     Add this new instance to a list of people  myList.add(person01)
     Repeat every second for 100 seconds  system.threading.thread.sleep(1000)
     Put this onto a WPF app and push to a label, with the new person appearing every second
         */
    }
}
