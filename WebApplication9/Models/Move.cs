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
        [StringLength(80,MinimumLength =5)]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { set; get; }
        public decimal Price { get; set; }
    }
}