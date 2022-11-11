namespace DependencyInjection.Services.Interfaces
{
    public class AspNet : IShow
    {
        public string Data { get; set; }

        public void Print(IDevice device)
        {
            Data = device.Show(this);
        }
    }





}
