using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class UpdateAccountSetModel : PageModel
    {
        private readonly ILogger<UpdateAccountSetModel> _logger;

        public UpdateAccountSetModel(ILogger<UpdateAccountSetModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
