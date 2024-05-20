using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRN221_GroupPRN_ChienNguyensrdn_.Model;

namespace PRN221_GroupPRN_ChienNguyensrdn_.Data
{
    public class PRN221_GroupPRN_ChienNguyensrdn_Context : DbContext
    {
        public PRN221_GroupPRN_ChienNguyensrdn_Context (DbContextOptions<PRN221_GroupPRN_ChienNguyensrdn_Context> options)
            : base(options)
        {
        }

        public DbSet<PRN221_GroupPRN_ChienNguyensrdn_.Model.User> User { get; set; } = default!;
    }
}
