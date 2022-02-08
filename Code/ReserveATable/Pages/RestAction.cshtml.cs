using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class RestActionModel : PageModel
    {
        private readonly ILogger<RestActionModel> _logger;

        public RestActionModel(ILogger<RestActionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
