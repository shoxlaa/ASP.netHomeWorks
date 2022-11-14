using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1111.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //1 
            ViewData["DateOfYear"] = DateTime.Now.DayOfYear;
            //2
            Random rnd = new Random();
            int num = rnd.Next(65,91);

            ViewData["Random"] = Convert.ToChar(num);
                


        }
    }
}