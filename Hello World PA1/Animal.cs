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
        public void PrintAnimal()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age + " years");
            Console.WriteLine("Weight: " + weight + "lbs.");
            Console.WriteLine("Sound: " + sound);
        }

        //This functions has the animal make a noise
        // Result: Animals noise is printed to the console
       public void MakeNoise()
        {
            Console.WriteLine(name + " says " + "\"" + sound + "\"");
        }

        //This function increases the animals age
        // Result: Animals age is increased by one year, with weight increase varying by animal children
        public void AgeUp()
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
        public void PrintAnimal()
        {
            base.PrintAnimal();
            Console.WriteLine("Breed: " + breed);
        }

        //This function increases the animals age
        // Result: Animals age is increased by one year, with weight increase varying by animal children
        public void AgeUp()
        {
            base.AgeUp();
            /* age++; // Increase age by one year

            if (age > 12 && weight > 7.0) // Once past a certain age animals grow old and feeble instead of stronger
                weight = weight - 0.5;
            else if (weight > 10)
                weight = weight + 0.5; // Fat cat weight gain
            else
                weight++; // Normal cat weight gain

            // Console writing
            Console.WriteLine("It's " + name + "'s birthday!");
            Console.WriteLine(name + " is now " + age + " years old, and they weigh " + weight + "lbs. "); */
        }

        public string GetName()
        {
            return base.GetName();
        }
    }
}
