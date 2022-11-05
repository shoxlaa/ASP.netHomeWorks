namespace DependencyInjection.Services
{
    public interface IShow
    {

        string Data { get; set; }
        public void Print(IDevice device);
    }





}
