using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
   
    public class Move
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$",ErrorMessage ="只能以字母开头")]
        public string Genre { set; get; }

        public decimal Price { get; set; }
        [Range(1,5)]
        public int rating { get; set; }
    }
}