using GameDataParser.Model;

namespace GameDataParser.UserInteraction;

public class GamesPrinter(IUserInteractor userInteractor) : IGamesPrinter
{
    private readonly IUserInteractor _userInteractor = userInteractor;

    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.PrintMessage($"{Environment.NewLine}Loaded games are:");
            foreach (var videoGame in videoGames)
            {
                _userInteractor.PrintMessage(videoGame.ToString());
            }
        }
    }
}