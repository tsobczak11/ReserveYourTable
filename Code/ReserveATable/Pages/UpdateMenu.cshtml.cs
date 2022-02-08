using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class UpdateMenuModel : PageModel
    {
        private readonly ILogger<UpdateMenuModel> _logger;

        public UpdateMenuModel(ILogger<UpdateMenuModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
