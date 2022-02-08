using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class RestConfirmModel : PageModel
    {
        private readonly ILogger<RestConfirmModel> _logger;

        public RestConfirmModel(ILogger<RestConfirmModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
