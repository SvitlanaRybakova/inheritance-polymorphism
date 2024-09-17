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

        #region // private fields
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        #endregion

        #region // constants
        const int minFNameChar = 2;
        const int maxFNameChar = 10;

        const int minLNameChar = 3;
        const int maxLNameChar = 15;

        const string AgeExeptionMessage = "Age must be greater than 0";
        readonly string FirstNameExeptionMessage = $"First name must be between {minFNameChar} and {maxFNameChar} characters";
        readonly string LastNameExeptionMessage = $"Last name must be between {minLNameChar} and {maxLNameChar} characters";

        #endregion

        #region // Public properties with validation
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException(AgeExeptionMessage);
                }
            }
        }
        public string FirstName
        {
            get { return fName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= minFNameChar && value.Length <= maxFNameChar)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException(FirstNameExeptionMessage);
                }
            }
        }
        public string LastName
        {
            get { return lName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= minLNameChar && value.Length <= maxLNameChar)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException(LastNameExeptionMessage);
                }
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        #endregion
    }
}