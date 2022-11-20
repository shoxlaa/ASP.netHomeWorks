﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using MvcWebApplication1.Models;
using MvcWebApplication1.Services;
using System.Text.Json;
using System.IO;
namespace MvcWebApplication1.Controllers
{
    public class NotesController : Controller
    {
        public readonly INotesList _notesList;
        public NotesController(INotesList notesList)
        {
            _notesList = notesList;
           // _notesList.AddItem(new Note() { Title = "Lol", Description = "dedee", DateTime = DateTime.Now });
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
            Console.WriteLine($"{title} ${description}");
            return Ok();
        }

        [HttpGet]
        public IActionResult GetResult()
        {
            ////_notesList.GetItems();
            //string fileName = "MyNotesss.json";
  
            //FileStream fs = new FileStream(fileName,FileMode.OpenOrCreate);
            JsonSerializer.Serialize(_notesList.GetItems());
            
            return Ok();
        }
        public IActionResult Edit(string title, string name, int index)
        {

            return View();
        }
    }
}
