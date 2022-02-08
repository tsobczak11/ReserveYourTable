using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class RestHelpModel : PageModel
    {
        private readonly ILogger<RestHelpModel> _logger;

        public RestHelpModel(ILogger<RestHelpModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
