namespace CookieCookbook.FileAccess;

public class FileMetadata(string name, FileFormat format)
{
    private string Name { get; } = name;
    private FileFormat Format { get; } = format;
    public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}