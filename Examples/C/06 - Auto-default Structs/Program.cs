//Money m = default;
Money m = new();
Console.WriteLine(m);

struct Money
{
    public int Euro { get; set; } = 99;
    public int Cents { get; set; } = 99;
    public int TotalCents => Euro * 100 + Cents;

    public override string ToString() => $"EUR {Euro}.{Cents:d2}";

    public Money()
    {
        //Euro = 0;
        //Cents = 0;
    }
}
