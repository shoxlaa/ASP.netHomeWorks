using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services.Classes
{
    public class PC : IDevice
    {
        public string Show(IShow show)
        {
            return nameof(PC);
        }
    }





}
