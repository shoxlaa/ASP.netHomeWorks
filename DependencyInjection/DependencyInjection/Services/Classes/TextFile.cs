using System.Runtime.InteropServices;

namespace DependencyInjection.Services.Interfaces;

public class TextFile : IShow
{
    IFileType _fileType;
    public TextFile(IFileType fileType)
    {
        _fileType = fileType;
    }
    public string Data { get; set; }
    public void Print(IDevice device)
    {
        _fileType.Create(device.Show(this));

    }
}
