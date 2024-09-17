
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
static  void CreateTheNewPerson(int age, string firstName, string lastName, double height, double weight)
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
