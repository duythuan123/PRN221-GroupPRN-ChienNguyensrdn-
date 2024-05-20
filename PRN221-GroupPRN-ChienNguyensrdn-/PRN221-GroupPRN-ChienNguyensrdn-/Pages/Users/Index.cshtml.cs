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
    public class IndexModel : PageModel
    {
        private readonly PRN221_GroupPRN_ChienNguyensrdn_.Data.PRN221_GroupPRN_ChienNguyensrdn_Context _context;

        public IndexModel(PRN221_GroupPRN_ChienNguyensrdn_.Data.PRN221_GroupPRN_ChienNguyensrdn_Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
