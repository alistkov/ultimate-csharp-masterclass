namespace UltimateCourse.Extensions;

public static class SeasonExtension
{
    public static Season Next(this Season season)
    {
        var seasonAsInt = (int)season;
        var nextSeason = (seasonAsInt + 1) % 4;
        return (Season)nextSeason;
    }
}