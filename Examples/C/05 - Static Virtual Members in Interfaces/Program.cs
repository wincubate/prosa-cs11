static T CreateObject<T>() where T : ICanCreateDefault<T>, new()
{
    return T.CreateDefault();
}

var person = CreateObject<Person>();
Console.WriteLine(person);
