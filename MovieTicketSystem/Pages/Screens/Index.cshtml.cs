using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieTicketSystem.Data;
using MovieTicketSystem.Models;

namespace MovieTicketSystem.Pages.Screens
{
    [Authorize(Roles = "Administrator")]
    public class IndexModel : PageModel
    {
        private readonly MovieTicketSystem.Data.MovieTicketContext _context;

        public IndexModel(MovieTicketSystem.Data.MovieTicketContext context)
        {
            _context = context;
        }

        public IList<Screen> Screen { get;set; } = default!;        public async Task OnGetAsync()
        {
            Screen = await _context.Screens.ToListAsync();
        }
    }
}
