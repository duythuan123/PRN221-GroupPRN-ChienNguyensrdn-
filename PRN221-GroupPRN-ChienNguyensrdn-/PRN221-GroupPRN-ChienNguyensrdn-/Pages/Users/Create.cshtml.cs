using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRN221_GroupPRN_ChienNguyensrdn_.Data;
using PRN221_GroupPRN_ChienNguyensrdn_.Model;

namespace PRN221_GroupPRN_ChienNguyensrdn_.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly PRN221_GroupPRN_ChienNguyensrdn_.Data.PRN221_GroupPRN_ChienNguyensrdn_Context _context;

        public CreateModel(PRN221_GroupPRN_ChienNguyensrdn_.Data.PRN221_GroupPRN_ChienNguyensrdn_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
