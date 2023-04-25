interface ICanCreateDefault<T> where T : ICanCreateDefault<T>, new()
{
    static virtual T CreateDefault() => new();
}
