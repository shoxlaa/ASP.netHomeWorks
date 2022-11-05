using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDevice _device;
        private readonly AspNet _show = new AspNet();
        public IndexModel(ILogger<IndexModel> logger, IDevice decive)
        {
            _logger = logger;
            _device = decive;
        }

        public void OnGet()
        {
            _device.Show(_show);
        }
    }
}