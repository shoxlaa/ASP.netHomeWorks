using System.Text.Json;

namespace DependencyInjection.Services.Interfaces;

public class JsonFileType : IFileType
{
    public JsonFileType()
    {
    }

    public void Create(string value)
    {
        string fileName = "data.json";
        string jsonString = JsonSerializer.Serialize(value);
        File.WriteAllText(fileName, jsonString);

    }
}
