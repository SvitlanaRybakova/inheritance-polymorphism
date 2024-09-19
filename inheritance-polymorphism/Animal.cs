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

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats() => $"The {this} class has the following properties: \n Name: {Name}, Weight: {Weight} kg, Age: {Age} year(s)";
    }

    public class Horse : Animal
    {
        public int NrOfRide { get; set; }
        public Horse(string name, double weight, int age, int nrOfRide) : base(name, weight, age)
        {
            NrOfRide = nrOfRide;
        }
        public override void DoSound() => Console.WriteLine("The horse neighs");

        public override string Stats() => $"{base.Stats()}, Number of rides: {NrOfRide} time(s)";
    }

    public class Dog : Animal
    {
        public int NrOfChewedSlippers { get; set; }
        public Dog(string name, double weight, int age, int nrOfChewedSlippers) : base(name, weight, age)
        {
            NrOfChewedSlippers = nrOfChewedSlippers;
        }
        public override void DoSound() => Console.WriteLine("The dog barks");

        public override string Stats() => $"{base.Stats()}, Number of chewed slippers: {NrOfChewedSlippers} piece(s)";
    }

    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public override void DoSound() => Console.WriteLine("The hedgehog makes some (have no idea) sound");

        public override string Stats() => $"{base.Stats()}, Number of spikes: {NrOfSpikes} piece(s)";
    }

    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }
        public override void DoSound() => Console.WriteLine("The worm makes no sound");

        public override string Stats() => $"{base.Stats()}, Is poisonous : {IsPoisonous}";

    }

    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }
        public override void DoSound() => Console.WriteLine("The bird sings");
        public override string Stats() => $"{base.Stats()},  WingSpan : {WingSpan} meter(s)";

    }

    public class Wolf : Animal
    {

        public int TeethAmmount { get; set; }
        public Wolf(string name, double weight, int age, int teethAmmount) : base(name, weight, age)
        {
            TeethAmmount = teethAmmount;
        }
        public override void DoSound() => Console.WriteLine("The wolf howls");

        public override string Stats() => $"{base.Stats()},  ammount of teeth : {TeethAmmount} piece(s)";
    }

    public class Pelican : Bird
    {
        public int NrOfFeathers { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, int nrOfFeathers)
            : base(name, weight, age, wingSpan)
        {
            NrOfFeathers = nrOfFeathers;
        }

        public override void DoSound() => Console.WriteLine("The pelican produces a low, hoarse sound");

        public override string Stats() => $"{base.Stats()}, Number of feathers : {NrOfFeathers} piece(s)";
    }

    public class Flamingo : Bird
    {
        public bool IsPink { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, bool isPink)
            : base(name, weight, age, wingSpan)
        {
            IsPink = isPink;
        }

        public override void DoSound() => Console.WriteLine("Flamingo vocalizations range from nasal honking to grunting or growling");

        public override string Stats() => $"{base.Stats()}, Is pink : {IsPink}";
    }

    public class Swan : Bird
    {
        public bool DidPlaySwanLake { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, bool didPlaySwanLake)
            : base(name, weight, age, wingSpan)
        {
            DidPlaySwanLake = didPlaySwanLake;
        }

        public override void DoSound() => Console.WriteLine("Swan gives the characteristic deep, trumpeting “oh-OH” call, with the second syllable emphasized");

        public override string Stats() => $"{base.Stats()}, Is this a part of Tchaikovsky's Swan Lake?: {DidPlaySwanLake}";
    }

    public interface IPerson
    {
        void Talk();
    }

    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, int teethAmmount)
            : base(name, weight, age, teethAmmount) { }

        public void Talk() => Console.WriteLine("The Wolfman says: Boo!");

        // does not have the uniq property and no needs to override the function
        // public override string Stats() => $"{base.Stats()}";
    }

    // För att säkerställa att alla fågelrelaterade klasser har tillgång till det nya attributet bör det definieras i deras gemensamma superklass => Bird klassen
    // Om alla djur beh;ver det nya attributet då lägga man det i Animal klasssen 
}