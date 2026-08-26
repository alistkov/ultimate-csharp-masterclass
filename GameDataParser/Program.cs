using System.Text.Json;

bool isFileRead = false;
var fileName = default(string);
var fileContent = default(string);
do
{
    try
    {
        Console.WriteLine("Enter the name of the file you want to read: ");
        fileName = Console.ReadLine();
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


List<VideoGame> videoGames;
try
{
    videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
}
catch (JsonException ex)
{
    var originalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"JSON in {fileName} was not in valid format. JSON body:");
    Console.WriteLine(fileContent);
    Console.ForegroundColor = originalColor;
    throw new JsonException($"{ex.Message} the file is: {fileName}", ex);
}

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
