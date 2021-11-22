using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTCSDL.DTO;
using LTCSDL.BLL;

namespace LTCSDL_ADONET_Web.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> lst;
        private CategoryBLL bus;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            bus = new CategoryBLL();
        }

        public void OnGet()
        {
            lst = bus.GetAll();
        }
    }
}
