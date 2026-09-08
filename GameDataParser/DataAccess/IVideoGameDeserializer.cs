using GameDataParser.Model;

namespace GameDataParser.DataAccess;

public interface IVideoGameDeserializer
{
    List<VideoGame> Deserialize(string fileContent, string fileName);
}