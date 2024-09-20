
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

CreateTheNewPerson(Convert.ToInt32(Utils.GetDoubleRandom(1, 100)), "Mary", "Marley", Utils.GetDoubleRandom(50, 200), Utils.GetDoubleRandom(3, 240));
CreateTheNewPerson(Convert.ToInt32(Utils.GetDoubleRandom(1, 100)), "Bob", "Marley", Utils.GetDoubleRandom(50, 200), Utils.GetDoubleRandom(3, 240));

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

static void CreateTheAnimalList()
{
    List<Animal> animals = new List<Animal>{
        new Horse("Alaska", Utils.GetDoubleRandom(2, 24), Convert.ToInt32(Utils.GetDoubleRandom(50, 1200)), Convert.ToInt32(Utils.GetDoubleRandom(2, 120))),
        new Dog("Bobby", Utils.GetDoubleRandom(2, 24), Convert.ToInt32(Utils.GetDoubleRandom(2, 12)), Convert.ToInt32(Utils.GetDoubleRandom(2, 12))),
        new Hedgehog("Spark", Utils.GetDoubleRandom(2, 24), Convert.ToInt32(Utils.GetDoubleRandom(2, 12)), Convert.ToInt32(Utils.GetDoubleRandom(1000, 20000)))
    };

    foreach (Animal animal in animals)
    {
        Console.WriteLine(animal.Stats());
        animal.DoSound();
       // animal.RandomString(); Metoden RandomString() är inte en del av Animal klassen, och kan inte anropas. RandomString() definerad i en Dog klassen.
    

        if (animal is IPerson person)
        {
            person.Talk();
        }
    }
    // Polymorfism tillåter oss att lagra olika subklasser i en lista över huvudklassen (Animal).
    // Varje subklass overrides Stats()-metoden, som anropas dynamiskt under körning.
   
}

CreateTheAnimalList();

static void CreateTheDogList()
{
    List<Dog> dogs = new List<Dog>{
        new Dog("Alaska", Utils.GetDoubleRandom(2, 24), Convert.ToInt32(Utils.GetDoubleRandom(2, 12)), Convert.ToInt32(Utils.GetDoubleRandom(2, 12))),
        new Dog("Bobby", Utils.GetDoubleRandom(2, 24), Convert.ToInt32(Utils.GetDoubleRandom(2, 12)), Convert.ToInt32(Utils.GetDoubleRandom(2, 12))),
        new Dog("Spark", Utils.GetDoubleRandom(2, 24), Convert.ToInt32(Utils.GetDoubleRandom(2, 12)), Convert.ToInt32(Utils.GetDoubleRandom(2, 12))),

    };

    // man kan inte lägga till en häst i en lista av hundar eftersom en häst och en hund är olika typer och tillhör olika klasser
    // för att lägga all klasser tillsammans listan måste vara av typen Animal
    foreach (Dog dog in dogs)
    {
        Console.WriteLine(dog.Stats());
        Console.WriteLine(dog.RandomString());
    }
}
CreateTheDogList();