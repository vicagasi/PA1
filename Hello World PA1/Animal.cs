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
    class Animal
    {
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
        public void printAnimal() 
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age + " years");
            Console.WriteLine("Weight: " + weight + "lbs.");
            Console.WriteLine("Sound: " + sound);
            Console.WriteLine(" ");
            Console.WriteLine("This creature is a strange mass of static, pixels, and burnt fur, the raw primordial ooze that makes all virtual animals.");
        }

        //This functions has the animal make a noise
        // Result: Animals noise is printed to the console
        public void makeNoise() 
        {
            Console.WriteLine(name + " says " + sound);
        }

        //This function increases the animals age
        // Result: Animals age is increased by one year, with weight increase varying by animal children
        public void ageUp() 
        {
            age++; // Increase age by one year

            if (age > 10 && weight > 5.0) // Once past a certain age animals grow old and feeble instead of stronger
                weight = weight - 0.5;
            else
                weight++; // Normal age weight gain

            // Console writing
            Console.WriteLine("It's " + name + "'s birthday!");
            Console.WriteLine(name + " is now " + age + " years old, and they weigh " + weight + "lbs. ");
        }
    }
}
