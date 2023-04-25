Money m1 = new(87, 25);
Money m2 = new(4, 75);
Money m3 = m1 + m2;

Console.WriteLine(m1);
Console.WriteLine(m2);
Console.WriteLine(m3);

record struct Money(int Euro, int Cents)
{
    public int TotalCents => Euro * 100 + Cents;

    public override string ToString() => $"EUR {Euro}.{Cents:d2}";

    public Money(int totalCents) : this(totalCents / 100, totalCents % 100)
    {
    }

    public static Money operator +(Money left, Money right) =>
        new(left.TotalCents + right.TotalCents);
}
