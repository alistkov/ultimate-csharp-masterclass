using System.Text.Json;

bool isFileRead = false;
var fileContent = default(string);
do
{
    try
    {
        Console.WriteLine("Enter the name of the file you want to read: ");
        var fileName = Console.ReadLine();
        fileContent = File.ReadAllText(fileName);
        isFileRead = true;
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("The filename cannot be null");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("The filename cannot be empty");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("The file does not exist");
    }
} while (!isFileRead);

var videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContent);



if (videoGames is not null && videoGames.Count > 0)
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
