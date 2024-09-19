using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    public class InvalidEmailError : UserError
    {
        public override string UEMessage()
        {
            return "The email address provided is not in a valid format";
        }
    }
    public class InvalidPasswordError : UserError
    {
        public override string UEMessage()
        {
            return "The password provided is invalid. It must contain at least 6 characters, including a number and a special character";
        }
    }

      public class UserAlreadyExistError : UserError
    {
        public override string UEMessage()
        {
            return "You have already registered. Duplicate registrations are not allowed";
        }
    }

}