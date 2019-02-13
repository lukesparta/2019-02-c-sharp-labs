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

            //input from user to confirm seconds in number
            seconds = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please pick a game mode (enter 1 or 2):\n\n" +
                "1. (Easy) Un-Ordered - Type as many characters as you can in the set seconds in any order.\n\n" +
                "2. (Hard) Ordered - Type as many characters as you can in the set seconds but in order of the alphabet (a, b, c..). If you get to 'z' before the game ends start from 'a' again. ");

            gameMode = Int32.Parse(Console.ReadLine());

            Stopwatch(seconds, gameMode);
        }

        static public void Stopwatch(int secs, int modeChoice)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            char[] order = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> userList = new List<char>();

            switch (modeChoice)
            {

                case 1:
                    ConsoleKeyInfo cki1;
                    do
                    {
                        while (Console.KeyAvailable == false)
                            Thread.Sleep(250); // Loop until input is entered.

                        cki1 = Console.ReadKey(true);
                        userList.Add(cki1.KeyChar);
                        Console.Write(cki1.KeyChar);
                        
                    } while (stopwatch.Elapsed.Seconds < secs);
                    stopwatch.Stop();
                    Console.WriteLine($"\n\n\nYou typed {userList.Count} characters in {secs} seconds. Press 'delete' to exit game.");
                    break;

                case 2:
                    ConsoleKeyInfo cki;
                    do
                    {
                        while (Console.KeyAvailable == false)
                            Thread.Sleep(250); // Loop until input is entered.

                        cki1 = Console.ReadKey(true);
                        userList.Add(cki1.KeyChar);
                        Console.Write(cki1.KeyChar);

                    } while (stopwatch.Elapsed.Seconds < secs);
                    Console.WriteLine(userList.Count);
                    stopwatch.Stop();
                    int count = 0;
                    int right = 0;
                    int wrong = 0;
                    while(count < userList.Count)
                    {
                        for (var i = 0; i < order.Length; i++)
                        {
                            if(i < userList.Count)
                            {
                                if (userList[i] == order[i])
                                {
                                    right++;
                                }
                                else
                                {
                                    wrong++;
                                }
                                count++;
                            }
                            
                        }
                    }
                    Console.WriteLine($"\n\n\nYou typed {userList.Count} characters in {secs} seconds. You got {right} right and {wrong} wrong. Press 'delete' to exit game.");

                    break;
                default:

                    break;
            }
            // Write hours, minutes and seconds.
            //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}

/*
 second counter
for (var i = 1; i < secs+1; i++)
{
    var task = Task.Delay(1000 + i);
    task.Wait();
    Console.WriteLine(i);
}    
*/
