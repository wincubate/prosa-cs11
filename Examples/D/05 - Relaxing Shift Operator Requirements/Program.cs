//int x = -8;
//int y = x >> "Hello!";

Money m1 = new(1, 28);
Money m2 = m1 << "WTF";
Money m3 = m1 >> "Argh!";

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

    public static Money operator <<(Money left, string right) =>
        new(left.TotalCents << right.Length);

    public static Money operator >>(Money left, string right) =>
        new(left.TotalCents >> right.Length);

    public static Money operator +(Money left, Money right) =>
        new(left.TotalCents + right.TotalCents);

    public static Money operator checked +(Money left, Money right)
    {
        checked
        {
            return new(left.TotalCents + right.TotalCents);
        }
    }
}
