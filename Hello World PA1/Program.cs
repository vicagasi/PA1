/*
 * Author: Victor Gasior 3
 * Date: 1/18/21
 * File: Program.cs
*/

using System;

namespace Hello_World_PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSelect = "null"; // Variable for users switch selection

            while (true)
            {
                Console.WriteLine("Please Select an Action: ");
                Console.WriteLine("(Q) Quit Program ");
                while (true)
                {
                    userSelect = Console.ReadLine();
                    if (userSelect != "q")
                    {
                        Console.WriteLine("Inccorrect Input, please try again.");
                    }
                    else
                    {
                        break;
                    }
                }


            }
        }
    }
}
