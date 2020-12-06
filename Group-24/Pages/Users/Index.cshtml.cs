using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_24.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Group_24.Pages.Users
{
    public class IndexModel : PageModel
    {
        public User UserRecord { get; set; }


        public void OnGet()
        {
        }
    }
}
