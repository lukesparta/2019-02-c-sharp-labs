using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace TouchType
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            int gameMode;
            Console.WriteLine("Welcome to the TouchType game. In this game you'll be timed how long it takes you to type characters a - b in seconds confirmed in the beginning.\n\nBefore you begin, please enter a number to confirm the amount of seconds you want to be timed by.");

            //store input from user to confirm seconds in number
            seconds = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please pick a game mode (enter 1 or 2):\n\n" +
                "1. (Easy) Un-Ordered - Type as many characters as you can in the set seconds in any order.\n\n" +
                "2. (Hard) Ordered - Type as many characters as you can in the set seconds but in order of the alphabet (a, b, c..). If you get to 'z' before the game ends start from 'a' again. ");

            //store game mode select from user input
            gameMode = Int32.Parse(Console.ReadLine());

            //call stopwatch method with user input as parameters
            Stopwatch(seconds, gameMode);
        }

        static public void Stopwatch(int secs, int modeChoice)
        {
            //create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //create char array containing char order
            char[] order = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //list for user char input
            List<char> userList = new List<char>();

            //swithc statement for game mode
            switch (modeChoice)
            {
                //easy game mode
                case 1:
                    ConsoleKeyInfo cki1;
                    //do while loop to execute code while < 'user input' seconds
                    do
                    {
                        while (Console.KeyAvailable == false)
                            Thread.Sleep(250); //loop until input is entered.

                        cki1 = Console.ReadKey(true);
                        userList.Add(cki1.KeyChar); //add user input to list 
                        Console.Write(cki1.KeyChar); //print user input
                        
                    } while (stopwatch.Elapsed.Seconds < secs);

                    //when time is up 
                    stopwatch.Stop(); //stop stopwatch

                    Console.WriteLine($"\n\n\nYou typed {userList.Count} characters in {secs} seconds. Press 'delete' to exit game.");
                    break;

                case 2:
                    ConsoleKeyInfo cki;
                    int count = 0;
                    int right = 0;
                    int wrong = 0;
                    //do while loop to execute code while < 'user input' seconds
                    do
                    {
                        while (Console.KeyAvailable == false)
                            Thread.Sleep(250); //loop until input is entered.

                        cki1 = Console.ReadKey(true);
                        userList.Add(cki1.KeyChar); //add user input to list 
                        Console.Write(cki1.KeyChar); //print user input

                    } while (stopwatch.Elapsed.Seconds < secs);

                    //when time is up 
                    stopwatch.Stop(); //stop stopwatch
                    
                    //while count is less than length of list 
                    while(count < userList.Count)
                    {
                        //loop through char array
                        for (var i = 0; i < order.Length; i++)
                        {
                            //if current loop number is less than the length of list of user input
                            if(i < userList.Count)
                            {
                                //if user input is the same as the char in the index of char array 
                                if (userList[i] == order[i])
                                {
                                    right++; //add one to right key stoke count
                                }
                                else
                                {
                                    wrong++; //add one to wrong key stroke count
                                }
                                count++; //add one to count
                            }
                        }
                    }
                    Console.WriteLine($"\n\n\nYou typed {userList.Count} characters in {secs} seconds. You got {right} right and {wrong} wrong. Press 'delete' to exit game.");
                    break;
                default:
                    break;
            }
        }
    }
}
