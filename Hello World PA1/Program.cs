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

            // Name selection string
            string nameSelect = "null";

            string userSelect = "null"; // Variable for users switch selection
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Please Select an Action: ");
                Console.WriteLine("(0) List Animals ");
                Console.WriteLine("(1) Create Animal ");
                Console.WriteLine("(2) Display Animal Info ");
                Console.WriteLine("(3) Make Animal Noise ");
                Console.WriteLine("(4) Age Animal Up ");
                Console.WriteLine("(Q) Quit ");

                userSelect = Console.ReadLine();

                bool correctInput = false; // Correct input check for several while statements
                switch (userSelect)
                {
                    case null:
                        Console.WriteLine("Inccorrect Input, please try again.");
                        break;

                    // Different Selection Options
                    case "q": // Quit Program
                        Console.WriteLine("Exiting...");
                        programRunning = false;
                        Environment.Exit(0);
                        break;

                    case "0" : // List Animals
                        foreach (Animal aAnimal in animals)
                        {
                            string name = aAnimal.GetName();
                            Console.WriteLine(name);
                        }
                        break;
                        
                    case "1" : // Create Animal
                        // Animal Selection
                        Console.WriteLine("Please Select an Animal: ");
                        Console.WriteLine("(1) Cat ");
                        Console.WriteLine("(2) Cassowary");
                        Console.WriteLine("(3) Capybara");

                        correctInput = false;
                        while (!correctInput)
                        {
                            userSelect = Console.ReadLine();

                            // Makes sure user makes a valid input
                            if (userSelect != "1" && userSelect != "2" && userSelect != "3")
                            {
                                Console.WriteLine("Inccorrect Input, please try again.");
                            }
                            else
                            {
                                correctInput = true;
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

                        // Actually Creating the Animals
                        if (userSelect == "1")
                        {
                            string catBreed = "Tabby"; // Select cat breed
                            Console.WriteLine("Whats the cats breed? ");
                            catBreed = Console.ReadLine();

                            animals.Add(new Cat(animalName, animalSound, catBreed, animalAge, animalWeight));
                        }
                        else if (userSelect == "2")
                        {
                            string featherColor = "Blue"; // Select feather color
                            Console.WriteLine("Whats the Cassowary's feather color? ");
                            featherColor = Console.ReadLine();

                            animals.Add(new Cassowary(animalName, animalSound, featherColor, animalAge, animalWeight));
                        }
                        else if (userSelect == "3")
                        {
                            string shadeColor = "Black"; // Select shade color
                            Console.WriteLine("Whats the Capybara's shade color? ");
                            shadeColor = Console.ReadLine();

                            animals.Add(new Capybara(animalName, animalSound, shadeColor, animalAge, animalWeight));
                        }
                        break;

                    case "2" :
                        Console.WriteLine("What animal would you like to display info for? ");
                        nameSelect = Console.ReadLine();

                        foreach (Animal aAnimal in animals)
                        {
                            string name = aAnimal.GetName();
                            if (nameSelect == name)
                                aAnimal.PrintAnimal();
                             
                        }

                        break;

                    case "3":
                        Console.WriteLine("What animal would you like to make a noise for? ");
                        nameSelect = Console.ReadLine();

                        foreach (Animal aAnimal in animals)
                        {
                            string name = aAnimal.GetName();
                            if (nameSelect == name)
                                aAnimal.MakeNoise();

                        }

                        break;

                    case "4":
                        Console.WriteLine("What animal would you like to age up? ");
                        nameSelect = Console.ReadLine();

                        foreach (Animal aAnimal in animals)
                        {
                            string name = aAnimal.GetName();
                            if (nameSelect == name)
                                aAnimal.AgeUp();

                        }

                        break;
                }
               

            }
        }
    }
}
