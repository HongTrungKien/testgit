using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KoiFishApp.Repositories.Entities;

namespace KoiFishApp.WebApplication.Pages.CTKoiFish
{
    public class CreateModel : PageModel
    {
        private readonly KoiFishApp.Repositories.Entities.QlcktnContext _context;

        public CreateModel(KoiFishApp.Repositories.Entities.QlcktnContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PondId"] = new SelectList(_context.Ponds, "PondId", "PondId");
            return Page();
        }

        [BindProperty]
        public KoiFish KoiFish { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.KoiFishes.Add(KoiFish);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
