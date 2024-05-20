using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PRN221_GroupPRN_ChienNguyensrdn_.Data;
using PRN221_GroupPRN_ChienNguyensrdn_.Model;

namespace PRN221_GroupPRN_ChienNguyensrdn_.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly PRN221_GroupPRN_ChienNguyensrdn_.Data.PRN221_GroupPRN_ChienNguyensrdn_Context _context;

        public DetailsModel(PRN221_GroupPRN_ChienNguyensrdn_.Data.PRN221_GroupPRN_ChienNguyensrdn_Context context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
