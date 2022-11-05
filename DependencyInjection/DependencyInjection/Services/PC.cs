namespace DependencyInjection.Services
{
    public class PC : IDevice
    {
        public string Show(IShow show)
        {
            return (nameof(PC));
        }
    }





}
