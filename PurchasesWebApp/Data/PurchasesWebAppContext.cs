using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PurchasesWebApp.Models;

namespace PurchasesWebApp.Data
{
    public class PurchasesWebAppContext : DbContext
    {
        public PurchasesWebAppContext (DbContextOptions<PurchasesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<PurchasesWebApp.Models.Expense> Expenses { get; set; } = default!;
    }
}
