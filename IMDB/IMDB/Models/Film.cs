using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IMDB.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Genre { get; set; }

        [Required]
        [MinLength(1)]
        public string Director { get; set; }

        public int? Year { get; set; }
    }
}