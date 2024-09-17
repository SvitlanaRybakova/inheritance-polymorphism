using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    public class PersonHandler
    {

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                FirstName = fName,
                LastName = lName,
                Height = height,
                Weight = weight
            };
            return person;
        }

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetFirstName(Person person, string fName)
        {
            person.FirstName = fName;
        }

        public void SetLastName(Person person, string lName)
        {
            person.LastName = lName;
        }

        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }

        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        public void PrintPersonDetails(Person person)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");
        }
    }
}