var person = Person.Empty;
Console.WriteLine(person);

interface ICanBeEmpty<T>
{
    static abstract T Empty { get; }
}

class Person : ICanBeEmpty<Person>
{
    public static Person Empty => new()
    {
        FirstName = "No",
        LastName = "Name"
    };

    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    public override string ToString() => $"{FirstName} {LastName}";
}