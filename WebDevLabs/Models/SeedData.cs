using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevLabs.Data;

namespace WebDevLabs.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcNotesCommentsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcNotesCommentsContext>>()))
            {
                if (context.Notes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Notes.AddRange(new Notes 
                {
                     Created = DateTime.Today,
                     Title = "Покорил Эверест",
                     Article = "Самой главной вершиной для большинства остается Эверест." +
                     " Первыми ее покорили новозеландец Эдмунд Хиллари с шерпой Норгеем Тенцингом." +
                     " В прошлом году мир отметил 65-летний юбилей первого восхождения." +
                     " А в этом — 100 лет со дня рождения Хиллари и 105 лет со дня рождения Тенцинга."
                });
                context.SaveChanges();
            }
        }
    }
}
