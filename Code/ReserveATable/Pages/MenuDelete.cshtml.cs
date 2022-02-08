using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class MenuDeleteModel : PageModel
    {
        private readonly ILogger<MenuDeleteModel> _logger;

        public MenuDeleteModel(ILogger<MenuDeleteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
