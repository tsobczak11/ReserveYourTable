using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class MenuAddModel : PageModel
    {
        private readonly ILogger<MenuAddModel> _logger;

        public MenuAddModel(ILogger<MenuAddModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
