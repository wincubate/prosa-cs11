var person = new Person("Paul", "Mullin");
Console.WriteLine(person.FirstName);

class Person
{
    public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string LastName { get; init; }

    public Person(string firstName, string lastName) : this(firstName, null, lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Person(string firstName, string? middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}