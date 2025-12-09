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
        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Author { get; set; }
        public DateTime? PublishedDate { get; set; }
        public Genre Genre { get; set; }
    }
}
