using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class RestLoginModel : PageModel
    {
        private readonly ILogger<RestLoginModel> _logger;

        public RestLoginModel(ILogger<RestLoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
