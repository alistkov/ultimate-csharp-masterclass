using System.Text.Json;

var app = new GameDataParserApp();
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
    logger.Log(ex);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class GameDataParserApp
{
    public void Run()
    {
        var fileName = ReadValidFilePathFromUser();
        var fileContent = File.ReadAllText(fileName);
        var videoGames = DeserializeVideoGamesFrom(fileContent, fileName);
        PrintGames(videoGames);
    }

    private static void PrintGames(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Loaded games are:");
            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }
        }
    }

    private static List<VideoGame> DeserializeVideoGamesFrom(string fileContent, string fileName)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
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
    }

    private static string ReadValidFilePathFromUser()
    {
        bool isFilePathValid = false;
        var fileName = default(string);
        do
        {
            Console.WriteLine("Enter the name of the file you want to read: ");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("The filename cannot be null");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The filename cannot be empty");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("The file does not exist");
            }
            else
            {
                isFilePathValid = true;
            }
        } while (!isFilePathValid);

        return fileName;
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