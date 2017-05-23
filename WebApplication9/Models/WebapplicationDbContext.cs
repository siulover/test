using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication9.Models
{
    public class WebapplicationDbContext:DbContext
    {
        public DbSet<Move> Moves { get; set; }
        public DbSet<MoveType> MoveTypes { get; set; }
    }
}