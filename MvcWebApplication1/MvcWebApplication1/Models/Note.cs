namespace MvcWebApplication1.Models
{
    public class Note
    {
        public string Name { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public string Tags { get; set; } = null!;

    }
}
