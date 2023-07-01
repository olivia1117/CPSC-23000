using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PurchasesWebApp.Data;
using PurchasesWebApp.Models;

namespace PurchasesWebApp.Pages.Expenses
{
    public class IndexModel : PageModel
    {
        private readonly PurchasesWebApp.Data.PurchasesWebAppContext _context;

        public IndexModel(PurchasesWebApp.Data.PurchasesWebAppContext context)
        {
            _context = context;
        }

        public IList<Expense> Expenses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Expenses != null)
            {
                Expenses = await _context.Expenses.ToListAsync();
            }
        }
    }
}
