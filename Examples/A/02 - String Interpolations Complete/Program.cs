using System;

string firstName = "Jesper";
string lastName = "Gulmann";
string company = "Wincubate ApS";

string s = $$"""
    {
      "firstName": "{{firstName}}",
      "lastName": "{{lastName}}",
      "company": "{{company}}"
    }
    """;

Console.WriteLine(s);


//int temperature = int.Parse(Console.ReadLine() ?? "0");
//string temperatureLine = $"The temperature is {temperature switch
//{
//    <= 0 => "Freezing...",
//    < 12 => "Autumn-like",
//    <= 19 => "Spring-ish",
//    <= 40 => "Summer!",
//    _ => "Death Valley?"
//}}";

//Console.WriteLine(temperatureLine);
