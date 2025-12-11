using BookLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BookLibrary.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a title")]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please provide an author")]
        [MaxLength(100)]
        public string? Author { get; set; }
        public DateTime? PublishedDate { get; set; }
        [EnumDataType(typeof(Genre), ErrorMessage ="Please select a genre")]
        public Genre Genre { get; set; }
    }
}
