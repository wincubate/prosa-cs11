using System.Text;

var bytes = """
    { "artist": "Red Warszawa",
      "AlbumName": "De 4 Årstider I Nordvest" }
    """u8;

var moreBytes = "Hello, "u8 + "World"u8 + "!!"u8;
byte[] moreBytesArray = moreBytes.ToArray();

foreach (var b in bytes)
{
    Console.Write($"{b} ");
}