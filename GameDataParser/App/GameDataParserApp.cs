using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;

namespace GameDataParser.App;

public class GameDataParserApp(
    IUserInteractor userInteractor,
    IGamesPrinter gamesPrinter,
    IVideoGameDeserializer videoGameDeserializer,
    IFileReader fileReader)
{
    private readonly IUserInteractor _userInteractor = userInteractor;
    private readonly IGamesPrinter _gamesPrinter = gamesPrinter;
    private readonly IVideoGameDeserializer _videoGameDeserializer = videoGameDeserializer;
    private readonly IFileReader _fileReader = fileReader;

    public void Run()
    {
        var fileName = _userInteractor.ReadValidFilePath();
        var fileContent = _fileReader.Read(fileName);
        var videoGames = _videoGameDeserializer.Deserialize(fileContent, fileName);
        _gamesPrinter.Print(videoGames);
    }
}