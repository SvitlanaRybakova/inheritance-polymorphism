using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    public class PersonHandler
    {
        public  void SetAge(Person person, int age)
        {
            person.Age = age;
        }
    }
}