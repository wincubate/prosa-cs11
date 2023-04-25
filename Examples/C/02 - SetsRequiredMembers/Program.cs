using System.Diagnostics.CodeAnalysis;

var person = new Person("Paul", "Mullin");

Console.WriteLine(person.FirstName);

class Person
{
    public required string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public required string LastName { get; init; }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
