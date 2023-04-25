var sequence = new[] { 42, 87, 112, 176 };
Console.WriteLine( MultSequence(sequence));

static int MultSequence( IEnumerable<int> sequence )
{
    int total = 1;
	foreach (var i in sequence)
	{
		total *= i;
	}

	return total;
}