using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesCRUDRazor.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }


    }
}