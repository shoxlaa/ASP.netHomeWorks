using Microsoft.AspNetCore.Mvc;
using MvcWebApplication1.Services;

namespace MvcWebApplication1.Controllers
{
    public class NotesController : Controller
    {
        public readonly INotesList _notesList;
        public NotesController(INotesList notesList)
        {
            _notesList = notesList;
        }
        public IActionResult Index()
        {
            return View();
        }
        //get from server 
        //post to server 

        //[HttpPost]
        //https://localhost:7224/Notes/AddNotes?title=hello&description=ophfrfgrf
        public IActionResult AddNotes(string title, string description)
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
            return Ok();
        }
        public IActionResult GetRuslts()
        {
            _notesList.GetItems();
            return Ok();
        }
        public IActionResult Edit(string title , string name , int index)
        {
           
            return View();
        }
    }
}
