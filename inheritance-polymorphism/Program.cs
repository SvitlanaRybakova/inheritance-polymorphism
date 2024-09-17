
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
PersonHandler handler = new PersonHandler();
Person person = handler.CreatePerson(20, "Bob", "Marley", 167, 78);
handler.SetAge(person, 18);
handler.PrintPersonDetails(person);
#endregion