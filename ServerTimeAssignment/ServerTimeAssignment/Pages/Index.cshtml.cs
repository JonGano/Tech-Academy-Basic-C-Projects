using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerTimeAssignment.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }//instantiated message property for use in onget method
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        
        public void OnGet()//onget method sends data to cshtmlpage
        {//this keyword points to the object for which the method is called
            this.Message = DateTime.UtcNow.ToString();
        }


    }
}