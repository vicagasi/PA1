/*
 * Author: Victor Gasior 3
 * Date: 1/18/21
 * File: Animal.cs
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_PA1
{
    abstract class Animal
    {
        // Properties
        private string name, sound;
        private int age;
        private double weight;

        // Default constructor for Animal
        public Animal()
        {
            name = "Misingno";
            sound = "*static*";
            age = 1;
            weight = 1.0;
        }

        // Parameterized constructor for Animal
        // Inputs: string name and sound, int age, double weight
        public Animal(string name, string sound, int age, double weight)
        {
            this.name = name;
            this.sound = sound;
            this.age = age;
            this.weight = weight;
        }

        //This functions prints details about the animal
        // Result: Info about the animal is printed to the console
        public virtual void PrintAnimal()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age + " years");
            Console.WriteLine("Weight: " + weight + "lbs.");
            Console.WriteLine("Sound: " + sound);
        }

        //This functions has the animal make a noise
        // Result: Animals noise is printed to the console
       public virtual void MakeNoise()
        {
            Console.WriteLine(name + " says " + "\"" + sound + "\"");
        }

        //This function increases the animals age
        // Result: Animals age is increased by one year, with weight increase varying by animal children
        public virtual void AgeUp()
        {
            age++; // Increase age by one year

            if (age > 20 && weight > 10.0) // Once past a certain age animals grow old and feeble instead of stronger
                weight = weight - 1;
            else if (weight > 20)
                weight = weight + 0.8; // Fat animal weight gain
            else
                weight++; // Normal animal weight gain

            // Console writing
            Console.WriteLine("It's " + name + "'s birthday!");
            Console.WriteLine(name + " is now " + age + " years old, and they weigh " + weight + "lbs. ");
        }

        public string GetName()
        {
            return name;
        }

        public string GetSound()
        {
            return sound;
        }

    }

    class Cat : Animal
    {
        // Properties
        private string breed;

        // Default constructor for Cat
        public Cat() : base()
        {
            breed = "Tabby";
        }

        // Parameterized constructor for Cat
        // Inputs: string name, sound and breed, int age, double weight
        public Cat(string name, string sound, string breed, int age, double weight) : base(name, sound, age, weight)
        {
            this.breed = breed;
        }

        //This functions prints details about the animal
        // Result: Info about the animal is printed to the console
        public override void PrintAnimal()
        {
            base.PrintAnimal();
            Console.WriteLine("Breed: " + breed);
        }

        //This functions has the animal make a noise
        // Result: Animals noise is printed to the console
        public override void MakeNoise()
        {
            string noise = GetSound();
            base.MakeNoise();
            if (noise != "meow" && noise != "Meow" && noise != "purr" && noise != "Purr")
                Console.WriteLine("Which is a strange noise for a cat, but whatever");
        }

        //This function increases the animals age
        // Result: Prints line of text specific to animal
        public override void AgeUp()
        {
            string name = GetName();
            base.AgeUp();
            Console.WriteLine("For its birthday " + name + " got a fresh fish with catnip seasoning.");
        }
    }

    class Cassowary: Animal
    {
        // Properties
        private string featherColor;

        // Default constructor for Cat
        public Cassowary() : base()
        {
            featherColor = "Blue";
        }

        // Parameterized constructor for Cat
        // Inputs: string name, sound and breed, int age, double weight
        public Cassowary(string name, string sound, string featherColor, int age, double weight) : base(name, sound, age, weight)
        {
            this.featherColor = featherColor;
        }

        //This functions prints details about the animal
        // Result: Info about the animal is printed to the console
        public override void PrintAnimal()
        {
            base.PrintAnimal();
            Console.WriteLine("Feather Color: " + featherColor);
        }

        //This functions has the animal make a noise
        // Result: Animals noise is printed to the console
        public override void MakeNoise()
        {
            string noise = GetSound();
            string name = GetName();
            Console.WriteLine(name + " chirps out a \"" + noise + "\".");
        }

        //This function increases the animals age
        // Result: Prints line of text specific to animal
        public override void AgeUp()
        {
            string name = GetName();
            base.AgeUp();
            Console.WriteLine("For its birthday " + name + " got a 10 pound jug of birdseed.");
        }
    }

    class Capybara : Animal
    {
        // Properties
        private string shadeColor;

        // Default constructor for Cat
        public Capybara() : base()
        {
            shadeColor = "Blue";
        }

        // Parameterized constructor for Cat
        // Inputs: string name, sound and breed, int age, double weight
        public Capybara(string name, string sound, string shadeColor, int age, double weight) : base(name, sound, age, weight)
        {
            this.shadeColor = shadeColor;
        }

        //This functions prints details about the animal
        // Result: Info about the animal is printed to the console
        public override void PrintAnimal()
        {
            string name = GetName();
            base.PrintAnimal();
            Console.WriteLine( name + " is wearing a slick pair of " + shadeColor + " shades.");
        }

        public override void MakeNoise()
        {
            string name = GetName();
            Console.WriteLine(name + " dosen't make any noise, because its fast asleep.");
        }

        //This function increases the animals age
        // Result: Prints line of text specific to animal
        public override void AgeUp()
        {
            string name = GetName();
            base.AgeUp();
            Console.WriteLine("For its birthday " + name + " got another slick pair of " + shadeColor + " shades. ");
        }
    }
}

