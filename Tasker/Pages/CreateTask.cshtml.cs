using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        [BindProperty]
        public Task NewTask { get; set; }
        private ApplicationDbContext _context { get; set; }
        public CreateTaskModel(ApplicationDbContext context)
        {

        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _context.Tasks.Add(NewTask);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
