using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Move
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public string Genre { set; get; }
        public decimal Price { get; set; }
        [Range(1,5)]
        public int rating { get; set; }
    }
}