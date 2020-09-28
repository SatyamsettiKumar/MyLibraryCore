using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Book Name")]
        public String BookName { get; set; }

        [Required]
        [Display(Name ="Author Name")]
        public String Author { get; set; }

        [Required]
        public String ISBN { get; set; }

        [Required]
        [Display(Name ="Genre Name")]
        public string Genre { get; set; }

        [Display(Name ="Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
