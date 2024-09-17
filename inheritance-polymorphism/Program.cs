
using inheritance_polymorphism;

Person person = new Person();
PersonHandler handler = new PersonHandler();
person.FirstName = "Bob";
person.LastName = "Marley";
handler.SetAge(person, 18);
Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Age);