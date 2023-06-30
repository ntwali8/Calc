using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Num1 { get; set; }

        [BindProperty]
        public string Num2 { get; set; }

        [BindProperty]
        public string Operations { get; set; }

        public IActionResult OnPost()
        {
            int result = 0;
            if(Operations == "+")
            {
                result = int.Parse(Num1) + int.Parse(Num2);
            }
            if (Operations == "-")
            {
                result = int.Parse(Num1) - int.Parse(Num2);
            }
            if (Operations == "/")
            {
                result = int.Parse(Num1) / int.Parse(Num2);
            }
            if (Operations == "x")
            {
                result = int.Parse(Num1) * int.Parse(Num2);
            }
            ViewData["Results"] = result;

            return Page();
        }
    }
}