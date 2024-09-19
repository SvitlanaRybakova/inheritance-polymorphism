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
        public int NrOfRide { get; set; }
        public Horse(string name, double weight, int age, int NrOfRide) : base(name, weight, age)
        {
            this.NrOfRide = NrOfRide;
        }
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs");
        }
    }

    public class Dog : Animal
    {
        public int NrOfChewedSlippers { get; set; }
        public Dog(string name, double weight, int age, int NrOfChewedSlippers) : base(name, weight, age)
        {
            this.NrOfChewedSlippers = NrOfChewedSlippers;
        }
        public override void DoSound()
        {
            Console.WriteLine("The dog barks");
        }
    }

    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int NrOfSpikes) : base(name, weight, age)
        {
            this.NrOfSpikes = NrOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog makes some (have no idea) sound");
        }
    }

    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, bool IsPoisonous) : base(name, weight, age)
        {
            this.IsPoisonous = IsPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("The worm makes no sound");
        }
    }

    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age, double WingSpan) : base(name, weight, age)
        {
            this.WingSpan = WingSpan;
        }
        public override void DoSound()
        {
            Console.WriteLine("The bird sings");
        }
    }

    public class Wolf : Animal
    {

        public int TeethAmmount { get; set; }
        public Wolf(string name, double weight, int age, int TeethAmmount) : base(name, weight, age)
        {
            this.TeethAmmount = TeethAmmount;
        }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls");
        }
    }
}