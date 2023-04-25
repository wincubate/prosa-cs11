
class Person :
    ICanBeEmpty<Person>,
    ICanCreateDefault<Person>
{
    public static Person Empty => new()
    {
        FirstName = string.Empty,
        LastName = string.Empty
    };

    //public static Person CreateDefault()
    //{
    //    return new()
    //    {
    //        FirstName = "Shigeru",
    //        LastName = "Miyamoto"
    //    };
    //}

    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    public override string ToString() => $"{FirstName} {LastName}";
}