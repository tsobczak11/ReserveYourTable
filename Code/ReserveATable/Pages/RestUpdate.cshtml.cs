using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class RestUpdateModel : PageModel
    {
        private readonly ILogger<RestUpdateModel> _logger;

        public RestUpdateModel(ILogger<RestUpdateModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
