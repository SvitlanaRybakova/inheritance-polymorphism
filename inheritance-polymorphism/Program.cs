
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using inheritance_polymorphism;

#region // define and init the Person property directly
// Person person = new Person();
// person.FirstName = "Bob";
// person.LastName = "Marley";
// person.Age = 18;
// person.Height = 167;
// person.Weight = 78;
#endregion

#region // add abstraction
static void CreateTheNewPerson(int age, string firstName, string lastName, double height, double weight)
{
    try
    {
        PersonHandler handler = new PersonHandler();
        Person person = handler.CreatePerson(age, firstName, lastName, height, weight);
        handler.PrintPersonDetails(person);

    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"The new error Argument Exeption happend: {ex.Message}");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"The new error Exeption occured: {ex.Message}");

    }
}
#endregion

CreateTheNewPerson(20, "Mary", "Marley", 150, 45);
CreateTheNewPerson(20, "Bob", "Marley", 167, 78);

static void CreateTheErrorsList()
{
    List<UserError> errors = new List<UserError>{
        new NumericInputError(),
        new TextInputError()

    };

    foreach (UserError error in errors)
    {
        Console.WriteLine(error.UEMessage());
    }

}
CreateTheErrorsList();

static void ValidateEmail(string email)
{

    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    if (!Regex.IsMatch(email, pattern))
    {
        UserError error = new InvalidEmailError();
        Console.WriteLine(error.UEMessage());

    }
    else
    {
        Console.WriteLine("Email has been accepted");
    }
}



ValidateEmail("notValidEmail");
ValidateEmail("validEmail@gmail.com");

static void ValidatePassword(string email)
{

    string pattern = @"^(?=.*[0-9])(?=.*[!@#$%^&*])[A-Za-z0-9!@#$%^&*]{6,}$";
    if (!Regex.IsMatch(email, pattern))
    {
        UserError error = new InvalidPasswordError();
        Console.WriteLine(error.UEMessage());

    }
    else
    {
        Console.WriteLine("The password has been accepted");
    }
}

ValidatePassword("123456");
ValidatePassword("!QW123456");

static void CheckTheUserRegistration(string email)
{
    List<string> registeredEmails = new List<string>
    {
        "bob.marley@gmail.com",
        "alice.smith@gmail.com",
        "existing.user@gmail.com"
    };


    if (registeredEmails.Contains(email))
    {
        UserError error = new UserAlreadyExistError();
        Console.WriteLine(error.UEMessage());

    }
    else
    {
        Console.WriteLine("You successfully registered");
    }
}
CheckTheUserRegistration("existing.user@gmail.com");
CheckTheUserRegistration("new.user@gmail.com");
