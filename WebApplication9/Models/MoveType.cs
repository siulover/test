using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class MoveType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { set; get; }
        public string Geric { get; set; }
        public string testCodeFirst { get; set; }
    }
}