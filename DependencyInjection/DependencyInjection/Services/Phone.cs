namespace DependencyInjection.Services
{
    public class Phone : IDevice
    {

        public string Show(IShow show)
        {
            return (nameof(Phone));
        }
    }





}
