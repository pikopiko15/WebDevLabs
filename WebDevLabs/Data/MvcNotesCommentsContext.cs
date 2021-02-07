using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevLabs.Models;

namespace WebDevLabs.Data
{
    public class MvcNotesCommentsContext : DbContext
    {
        public MvcNotesCommentsContext(DbContextOptions<MvcNotesCommentsContext> options) : base(options)
        {
            
        }

        public DbSet<Notes> Notes { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
