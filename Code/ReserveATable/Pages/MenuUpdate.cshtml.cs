using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class MenuUpdateModel : PageModel
    {
        private readonly ILogger<MenuUpdateModel> _logger;

        public MenuUpdateModel(ILogger<MenuUpdateModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
