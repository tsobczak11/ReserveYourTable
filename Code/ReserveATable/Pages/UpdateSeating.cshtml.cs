using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class UpdateSeatingModel : PageModel
    {
        private readonly ILogger<UpdateSeatingModel> _logger;

        public UpdateSeatingModel(ILogger<UpdateSeatingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
