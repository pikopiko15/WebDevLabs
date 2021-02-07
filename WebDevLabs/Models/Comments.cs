using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevLabs.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public string Author { get; set; }
        public string Comment { get; set; }

        public long? NoteId { get; set; }
        public Notes Note { get; set; }
    }
}
