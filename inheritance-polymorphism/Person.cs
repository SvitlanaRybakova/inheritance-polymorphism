using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

    }
}