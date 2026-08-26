using System.Text.Json;
using GameDataParser.Model;
using GameDataParser.UserInteraction;

namespace GameDataParser.DataAccess;

public class VideoGameDeserializer(IUserInteractor userInteractor) : IVideoGameDeserializer
{
    private readonly IUserInteractor _userInteractor = userInteractor;

    public List<VideoGame> Deserialize(string fileContent, string fileName)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
        }
        catch (JsonException ex)
        {
            _userInteractor.PrintError($"JSON in {fileName} was not in valid format. JSON body:");
            _userInteractor.PrintError(fileContent);
            throw new JsonException($"{ex.Message} the file is: {fileName}", ex);
        }
    }
}