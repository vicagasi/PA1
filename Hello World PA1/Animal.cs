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

        public Animal()
        {
            name = "Null";
            sound = "bzzzzz";
            age = 1;
            weight = 1.0;
        }

        public void printAnimal()
        {

        }

        public void makeNoise()
        {
            Console.WriteLine(name + " says " + sound);
        }

        public void ageUp()
        {

        }
    }
}
