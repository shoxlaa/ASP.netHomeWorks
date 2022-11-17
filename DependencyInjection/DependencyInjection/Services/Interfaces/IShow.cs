namespace DependencyInjection.Services.Interfaces;

public interface IShow
{

    string Data { get; set; }
    public void Print(IDevice device);
}




