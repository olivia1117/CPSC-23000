using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PurchasesWebApp.Data;
using PurchasesWebApp.Models;

namespace PurchasesWebApp.Pages.Expenses
{
    public class CreateModel : PageModel
    {
        private readonly PurchasesWebApp.Data.PurchasesWebAppContext _context;

        public CreateModel(PurchasesWebApp.Data.PurchasesWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Expense Expenses { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Expenses == null || Expenses == null)
            {
                return Page();
            }

            _context.Expenses.Add(Expenses);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
