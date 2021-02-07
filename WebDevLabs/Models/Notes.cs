using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebDevLabs.Models
{
    public class Notes
    {
        public long Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        public string Title { get; set; }

        public string  Article { get; set; }

        public ICollection<Comments> Comments { get; set; }

        public Notes()
        {
            Comments = new List<Comments>();
        }
    }
}
