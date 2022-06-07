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
    public class DetailsModel : PageModel
    {
        private readonly FopTecProject.Models.CustomersContext _context;

        public DetailsModel(FopTecProject.Models.CustomersContext context)
        {
            _context = context;
        }

      public Customers Customers { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customers == null)
            {
                return NotFound();
            }
            else 
            {
                Customers = customers;
            }
            return Page();
        }
    }
}
