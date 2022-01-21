/*
 * Author: Victor Gasior 3
 * Date: 1/18/21
 * File: Program.cs
*/

using System;
using System.Collections.Generic;

namespace Hello_World_PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.World();
        }

        // Main driver for the program, allows the user to interact with a console menu for creating and interacting with creatures
        // Result: User runs through menu, until they exit
        void World()
        {
            // List for all the animals
            List<Animal> animals = new List<Animal>();

            string userSelect = "null"; // Variable for users switch selection

            while (true)
            {
                Console.WriteLine("Please Select an Action: ");
                Console.WriteLine("(0) List Animals ");
                Console.WriteLine("(1) Create Animal ");
                Console.WriteLine("(2) Display Animal Info ");
                Console.WriteLine("(3) Make Animal Noise ");
                Console.WriteLine("(4) Create Animal ");
                Console.WriteLine("(5) Age Animal Up ");
                Console.WriteLine("(Q) Quit ");
                while (true)
                {
                    userSelect = Console.ReadLine();

                    // Makes sure user makes a valid input
                    if (userSelect != "q" && userSelect != "Q" && userSelect != "0" && userSelect != "1" && userSelect != "2" && userSelect != "3" && userSelect != "4" && userSelect != "5")
                    {
                        Console.WriteLine("Inccorrect Input, please try again.");
                    }
                    else
                    {
                        break;
                    }
                }

                switch (userSelect)
                {
                    // Different Selection Options
                    case "q" :
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    case "0" : // List Animals
                        Cat cat = new Cat();
                        foreach (Animal aAnimal in animals)
                        {
                            string name = cat.GetName();
                            Console.WriteLine(name);
                        }
                        break;
                        
                    case "1" : // Create Animal
                        // Animal Selection
                        Console.WriteLine("Please Select an Animal: ");
                        Console.WriteLine("(1) Cat ");
                        Console.WriteLine("(2) Cassowary");
                        Console.WriteLine("(3) Capybara");

                        while (true)
                        {
                            userSelect = Console.ReadLine();

                            // Makes sure user makes a valid input
                            if (userSelect != "1" && userSelect != "2" && userSelect != "3")
                            {
                                Console.WriteLine("Inccorrect Input, please try again.");
                            }
                            else
                            {
                                break;
                            }
                        }

                        // Animal Values
                        string animalName = "Greg";
                        Console.WriteLine("Whats the animals name? ");
                        animalName = Console.ReadLine();

                        string animalSound = "meow";
                        Console.WriteLine("Whats the animals sound? ");
                        animalSound = Console.ReadLine();

                        int animalAge = 1;
                        Console.WriteLine("Whats the animals age? ");
                        string tempAge = Console.ReadLine();
                        animalAge = int.Parse(tempAge);

                        double animalWeight = 3.0;
                        Console.WriteLine("Whats the animals weight? ");
                        string tempWeight = Console.ReadLine();
                        animalWeight = double.Parse(tempWeight);
                        break;

                        // Actually Creating the Animals
                        if (userSelect == "1")
                        {
                            string catBreed = "Tabby"; // Select cat breed

                            animals.Add(new Cat(animalName, animalSound, catBreed, animalAge, animalWeight));
                        }
                        break;

                    case "2" :
                        Console.WriteLine("What animal would you like to display info for? ");
                        string nameSelect = Console.ReadLine();

                        break;
                }
               

            }
        }
    }
}
