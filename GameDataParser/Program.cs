using System.Text.Json;

Console.Write("Enter the name of the file you want to read: ");
var fileName = Console.ReadLine();
var fileContent = File.ReadAllText(fileName);
var videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContent);

if (videoGames.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("Loaded games are:");
    foreach (var videoGame in videoGames)
    {
        Console.WriteLine(videoGame);
    }
}

public class VideoGame
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString() =>
        $"{Title}, released in {ReleaseYear}, rating: {Rating}";
}
