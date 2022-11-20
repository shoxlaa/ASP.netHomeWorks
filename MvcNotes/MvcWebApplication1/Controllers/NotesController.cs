using Microsoft.AspNetCore.Mvc;
using MvcWebApplication1.Models;
using MvcWebApplication1.Services;
using System.Text.Json;

namespace MvcWebApplication1.Controllers
{
    public class NotesController : Controller
    {
        public readonly INotesList _notesList;
        public readonly JsonWriter _writer;
        public NotesController(INotesList notesList, JsonWriter jsonWriter)
        {
            _notesList = notesList;
            _notesList.AddItem(new Note() { Title = "Hello", Description = "dedee", DateTime = DateTime.Now });
        }
        public IActionResult Index()
        {
            return View();
        }
        //get from server 
        //post to server 
        //https://localhost:7224/Notes/AddNotes?title=hello&description=ophfrfgrf
        [HttpPost]
        public IActionResult Add(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                return BadRequest();
            }
            _notesList.AddItem(new()
            {
                Title = title,
                Description = description,
                DateTime = DateTime.Now
            });
            Console.WriteLine($"{title}${description}");
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetResult()
        {
            //_notesList.GetItems();
            await _writer.WriteAsync(_notesList.GetItems());
            return Ok();
        }
        public IActionResult Edit(string title, string name, int index)
        {

            return View();
        }
    }
}
