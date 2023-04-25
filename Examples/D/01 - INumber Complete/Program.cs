using System.Numerics;

var sequence = new[] { 42, 87, 112, 176 };
Console.WriteLine(MultSequence(sequence));

static T MultSequence<T>(IEnumerable<T> sequence) where T : INumber<T>
{
    T total = T.One;
    foreach (T i in sequence)
    {
        total *= i;
    }

    return total;
}