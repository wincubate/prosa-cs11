ReadOnlySpan<char> s1 = "Hello World";
Console.WriteLine(s1 is "Hello");

Span<char> s2 = "etc".ToCharArray();
Console.WriteLine(IsKnownAbbreviation(s2));

static bool IsKnownAbbreviation(Span<char> s) =>
    s switch
    {
        "etc" or "ie" => true,
        _ => false
    };
