using System.Text;

string payload = """
    { "artist": "Red Warszawa",
      "AlbumName": "De 4 Årstider I Nordvest" }
    """;
byte[] bytes = Encoding.Unicode.GetBytes(payload);

foreach (var b in bytes)
{
    Console.Write($"{b} ");
}