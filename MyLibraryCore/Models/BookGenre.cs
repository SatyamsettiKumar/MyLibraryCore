using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryCore.Models
{
    public class BookGenre
    {
        public Book Book { get; set; }

        public IEnumerable<SelectListItem> Gender { get; set; }
    }
}
