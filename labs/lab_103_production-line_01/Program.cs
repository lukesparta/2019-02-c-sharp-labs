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
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(randomNumberGen());
                Thread.Sleep(1000);
            }
        }

        //randomly select person from array
        static public string randomNumberGen()
        {
            string[] people = new string[] { "Luke Dawes", "John Doe",
                                        "James Carter", "Travis Scott",
                                        "Donald Trump", "Burno Mars",
                                        "Justin Beiber", "Frank Ocean",
                                        "Beyonce Knowles", "Lyrn Hill"};

            Random randomNum = new Random();
            int rn = randomNum.Next(people.Length);

            return people[rn];
        }
    }

    

    class Parent
    {
        //properties
        public string name;
        public int age;
        public DateTime dob;

        //array of 10 people
        


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
