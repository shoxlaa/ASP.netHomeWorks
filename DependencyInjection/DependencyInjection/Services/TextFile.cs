namespace DependencyInjection.Services
{
    public class TextFile : IShow
    {
        public string Data { get; set; }
        public void Print(IDevice device)
        {
            File.WriteAllText("myfile.txt", device.Show(this));
           
        }
    }





}
