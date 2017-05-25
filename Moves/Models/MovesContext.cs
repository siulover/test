using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Moves.Models
{
    public class MovesContext:DbContext
    {
        public DbSet<Move> Moves { get; set; }
    }
}