using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class NewReservationModel : PageModel
    {
        private readonly ILogger<NewReservationModel> _logger;

        public NewReservationModel(ILogger<NewReservationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
