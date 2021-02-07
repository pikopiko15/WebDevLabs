using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebDevLabs.Data;
using WebDevLabs.Models;

namespace WebDevLabs.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcNotesCommentsContext _context;

        public HomeController(MvcNotesCommentsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var notes = await _context.Notes
                .FirstOrDefaultAsync();
            if (notes == null)
            {
                return NotFound();
            }

            return View(notes);
        }

        public IActionResult Inform()
        {
            return View();
        }
    }
}
