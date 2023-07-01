using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurchasesWebApp.Data;
using PurchasesWebApp.Models;

namespace PurchasesWebApp.Pages.Expenses
{
    public class EditModel : PageModel
    {
        private readonly PurchasesWebApp.Data.PurchasesWebAppContext _context;

        public EditModel(PurchasesWebApp.Data.PurchasesWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Expense Expenses { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Expenses == null)
            {
                return NotFound();
            }

            var expenses =  await _context.Expenses.FirstOrDefaultAsync(m => m.ID == id);
            if (expenses == null)
            {
                return NotFound();
            }
            Expenses = expenses;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Expenses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpensesExists(Expenses.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExpensesExists(int id)
        {
          return (_context.Expenses?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
