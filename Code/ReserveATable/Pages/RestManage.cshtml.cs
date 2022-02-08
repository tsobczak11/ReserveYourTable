using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class RestManageModel : PageModel
    {
        private readonly ILogger<RestManageModel> _logger;

        public RestManageModel(ILogger<RestManageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
