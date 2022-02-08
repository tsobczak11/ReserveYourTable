using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class MenuUploadModel : PageModel
    {
        private readonly ILogger<MenuUploadModel> _logger;

        public MenuUploadModel(ILogger<MenuUploadModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
