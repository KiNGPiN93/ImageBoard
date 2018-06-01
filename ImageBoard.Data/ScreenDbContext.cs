using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImageBoard.Data
{
    public class ScreenDbContext : DbContext
    {
        public ScreenDbContext() : base("DefaultConnection")
        { }

        public DbSet<Bild> Name { get; set; }
        public DbSet<Bild> Date { get; set; }
    }
}