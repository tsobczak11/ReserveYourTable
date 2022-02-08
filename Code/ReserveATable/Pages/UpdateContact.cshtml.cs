using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class UpdateContactModel : PageModel
    {
        private readonly ILogger<UpdateContactModel> _logger;

        public UpdateContactModel(ILogger<UpdateContactModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
