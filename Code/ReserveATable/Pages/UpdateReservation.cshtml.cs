using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveATable.Pages
{
    public class UpdateReservationModel : PageModel
    {
        private readonly ILogger<UpdateReservationModel> _logger;

        public UpdateReservationModel(ILogger<UpdateReservationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
