namespace DependencyInjection.Services.Interfaces;

public class TxtFileType : IFileType
{
    public TxtFileType()
    {
    }

    public void Create(string value)
    {
        File.WriteAllText("data.txt", value);
    }
}
