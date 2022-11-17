using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services.Classes
{
    public class Phone : IDevice
    {

        public string Show(IShow show)
        {
            return nameof(Phone);
        }
    }





}
