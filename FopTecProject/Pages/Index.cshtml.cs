using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FopTecProject.Model;
using FopTecProject.Models;

namespace FopTecProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FopTecProject.Models.CustomersContext _context;

        public IndexModel(FopTecProject.Models.CustomersContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customers = await _context.Customers.ToListAsync();
            }
        }
    }
}
