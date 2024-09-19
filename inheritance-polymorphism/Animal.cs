using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    public abstract class Animal
    {
        // Properties common to all animals
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }

    public class Horse : Animal
    {
        public Horse(string name, double weight, int age) : base(name, weight, age) { }
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, double weight, int age) : base(name, weight, age) { }
        public override void DoSound()
        {
            Console.WriteLine("The dog barks");
        }
    }

    public class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age) : base(name, weight, age) { }
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog makes some (have no idea) sound");
        }
    }

    public class Worm : Animal
    {
        public Worm(string name, double weight, int age) : base(name, weight, age) { }
        public override void DoSound()
        {
            Console.WriteLine("The worm makes no sound");
        }
    }

     public class Bird : Animal
    {
        public Bird(string name, double weight, int age) : base(name, weight, age) { }
        public override void DoSound()
        {
            Console.WriteLine("The bird sings");
        }
    }

     public class Wolf : Animal
    {
        public Wolf(string name, double weight, int age) : base(name, weight, age) { }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls");
        }
    }
}