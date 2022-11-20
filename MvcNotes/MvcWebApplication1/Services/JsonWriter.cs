using MvcWebApplication1.Models;
using System.Text.Json;


namespace MvcWebApplication1.Services
{
    public class JsonWriter
    {
        public string _fileName { get; set; } = "myjson.json";
        public INotesList _notesList;
        public JsonWriter(INotesList Object)
        {
            _notesList = Object;

        }
        public async Task WriteAsync(IEnumerable<Note> value)
        {
            using FileStream createStream = File.Create(_fileName);
            await JsonSerializer.SerializeAsync<IEnumerable<Note>>(createStream,value);
            await createStream.DisposeAsync();
        }
        public async Task<INotesList> ReadAsytnc()
        {
            using FileStream openStream = File.OpenRead(_fileName);
            INotesList? Notes =
                await JsonSerializer.DeserializeAsync<INotesList>(openStream);
            return Notes;
        }
    }
}
