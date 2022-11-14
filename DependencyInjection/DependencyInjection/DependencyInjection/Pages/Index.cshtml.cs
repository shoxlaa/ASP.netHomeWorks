using DependencyInjection.Services;
using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DependencyInjection.Services.Interfaces;
using DependencyInjection.Services.Classes;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDevice _device= new PC();
       // private readonly IShow _show =new TextFile(new JsonFileType());
        private readonly IShow _show = new AspNet();
        public IndexModel(ILogger<IndexModel> logger , IDevice device , IShow show)
        {
            _logger = logger;
            _device = device;
            _show = show;
        }

        public void OnGet()
        {
            _show.Print(_device);
            ViewData["AspString"] = _show.Data;
        }
    }
}